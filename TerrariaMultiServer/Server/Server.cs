using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TerrariaMultiServer
{
    [Serializable]
    public class Server
    {
        [NonSerialized]
        bool startedOutputStreamRead;
        [NonSerialized]
        const int logSize = 30;
        public string serverName { get; set; }
        public string serverDirectory;
        [JsonIgnore]
        public string[] serverLog { get; private set; }
        [NonSerialized]
        public Process serverProcess;
        [JsonIgnore]
        public bool isRunning { get; private set; }
        //pulled from the changelog in the server files
        public string Version()
        {
            if (File.Exists(serverDirectory + "\\changelog.txt"))
            {
                StreamReader streamReader = new StreamReader(serverDirectory + "\\changelog.txt");
                string versionLine = streamReader.ReadLine();
                streamReader.Close();
                if (versionLine.Split(' ').Length > 1) return versionLine.Split(' ')[1];
                else return "problem parsing version from changelog.txt";
            }
            return "changelog.txt doesn't exist";
        }
        [NonSerialized]
        private TerrariaConfig _serverConfig;
        [JsonIgnore]
        public TerrariaConfig serverConfig 
        { 
            get 
            { 
                return _serverConfig; 
            } 
            set 
            {
                _serverConfig = value;
                if (_serverConfig == null) return;
                File.WriteAllLines(serverDirectory + "\\serverconfig.txt",
                    new string[]
                    {
                        "port=" + value.config["port"],
                        "maxplayers=" + value.config["maxplayers"],
                        "world=" + value.config["world"],
                        "autocreate=" + value.config["autocreate"],
                        "banlist=" + value.config["banlist"],
                        "worldname=" + value.config["worldname"],
                        "worldpath=" + value.config["worldpath"],
                        "secure=" + value.config["secure"],
                        "upnp=" + value.config["upnp"],
                        "ip=" + value.config["ip"],
                        "seed=" + value.config["seed"],
                        "difficulty=" + value.config["difficulty"],
                        "motd=" + value.config["motd"],
                        "language=" + value.config["language"],
                        "priority=" + value.config["priority"],
                        "npcstream=" + value.config["npcstream"],
                        "password=" + value.config["password"]
                    });
            } 
        }

        public Server(string _serverName, string _serverDirectory)
        {
            serverName = _serverName;
            serverDirectory = _serverDirectory;
            serverProcess = new Process();
            serverLog = new string[logSize];
            for (int i = 0; i < logSize; i++) serverLog[i] = "";
        }
        [OnDeserialized()]
        void OnDeseralized(StreamingContext context) 
        {
            _serverConfig = new TerrariaConfig(serverDirectory + "\\serverconfig.txt");
        }
        public void StartServer()
        {
            //check to see if the server is currently running if it is prompt the user to close the server
            if (serverDirectory == null) return;
            Process[] currentlyRunningServers = Process.GetProcessesByName("TerrariaServer");
            foreach (Process server in currentlyRunningServers)
            {
                if (server.MainModule.FileName == serverDirectory + "\\TerrariaServer.exe")
                {
                    MessageBox.Show("Server is currently running, please close it before trying to start the server");
                    return;
                }
            }
            //make sure the exe file exists before trying to execute it
            if (!File.Exists(serverDirectory + "\\TerrariaServer.exe"))
            {
                MissingFilesDialogue missingFilesDialogue = new MissingFilesDialogue(new string[] { "TerrariaServer.exe" });
                missingFilesDialogue.ShowDialog();
                return;
            }
            serverProcess.StartInfo.Arguments = "-config serverconfig.txt";
            serverProcess.StartInfo.FileName = serverDirectory + "\\TerrariaServer.exe";
            serverProcess.StartInfo.WorkingDirectory = serverDirectory;
            serverProcess.EnableRaisingEvents = true;
            serverProcess.Exited += ServerProcess_Exited;
            serverProcess.StartInfo.UseShellExecute = false;
            serverProcess.StartInfo.RedirectStandardOutput = true;
            serverProcess.OutputDataReceived += ServerOutputDataReceived;
            serverProcess.Start();
            if (!startedOutputStreamRead) 
            {
                serverProcess.BeginOutputReadLine();
                startedOutputStreamRead = true;
            }
            //wait for the window to be created then hide it using winapi
            while (serverProcess.MainWindowHandle == IntPtr.Zero) Thread.Sleep(50);
            NativeMethods.ShowWindow(serverProcess.MainWindowHandle, 0);
            isRunning = true;
        }

        private void ServerOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            string parsedData = e.Data;
            if (parsedData == null) return;
            if (parsedData.Length > 0) 
            {
                //remove the random space colon that sometimes appears in the data
                if (parsedData[0].ToString() + parsedData[1].ToString() == ": ") 
                    parsedData = parsedData.Remove(0, 2);
                if (parsedData.Length == 0) return;
                //if the line starts with "<" then it is most likely a chat message that needs evaluated for a command
                if (parsedData[0] == '<')
                {
                    string playerName = parsedData.Substring(parsedData.IndexOf('<') + 1, parsedData.IndexOf('>') - 1);
                    //split by the space that is always included in a chat message
                    //do not include messages that come from the server console
                    if (playerName != "Server")
                    {
                        string[] splitData = parsedData.Split(' ');
                        if (splitData.Length > 1)
                        {
                            if (splitData[1].Length > 1)
                            {
                                //if what the person typed starts with our command character then evaluate as a command
                                if (splitData[1][0] == '\\')
                                {
                                    string actualCommand = "";
                                    if (splitData.Length - 1 > 1)
                                    {
                                        actualCommand = splitData[1].Substring(1, splitData[1].Length - 1) + " " + string.Join(" ", splitData, 2, splitData.Length - 2);
                                    }
                                    else
                                    {
                                        actualCommand = splitData[1].Substring(1, splitData[1].Length - 1) + string.Join(" ", splitData, 2, splitData.Length - 2);
                                    }
                                    RunCrossServerCommand(this, new CrossServerCommandEventArgs(serverName, playerName, actualCommand));
                                }
                                //if it isn't a command treat it as a normal message which we raise the cross server command event 
                                //in case cross server chat is enabled
                                else
                                {
                                    string actualMessage = string.Join(" ", splitData, 1, splitData.Length - 1);
                                    //string actualMessage = splitData[1].Substring(0, splitData[1].Length);
                                    RunCrossServerCommand(this, new CrossServerCommandEventArgs(serverName, playerName, "crossServerMessage " + actualMessage));
                                }
                            }
                        }
                    }
                }
            }
            //somewhere in here we need to figure out a way to send feedback to the players in the game on commands
            log(parsedData);
        }

        public void StopServer()
        {
            if (isRunning)
            {
                Process[] allTerrariaServers = Process.GetProcessesByName("TerrariaServer");
                foreach (Process terrariaServer in allTerrariaServers)
                {
                    if (terrariaServer.MainModule.FileName == serverDirectory + "\\TerrariaServer.exe") 
                    {
                        terrariaServer.Kill();
                    }
                }
                //serverProcess.Kill();
            }
            else MessageBox.Show("Server is currently not running or wasn't started by Terraria Multi Server");
        }
        //character is the special character that needs converted
        //the string is the name of that character according to the keys enum
        //the bool specifies if shift needs held down while the message is sent to the terraria server console window
        readonly Dictionary<char, (string, bool)> specialCharacters = new Dictionary<char, (string, bool)>
        {
            { '`', ("Oemtilde",false) },
            { '~', ("Oemtilde",true) },
            { '!', ("D1",true) },
            { '@', ("D2",true) },
            { '#', ("D3",true) },
            { '$', ("D4",true) },
            { '%', ("D5",true) },
            { '^', ("D6",true) },
            { '&', ("D7",true) },
            { '*', ("D8",true) },
            { '(', ("D9",true) },
            { ')', ("D10",true) },
            { '-', ("OemMinus",false) },
            { '_', ("OemMinus",true) },
            { '=', ("Oemplus",false) },
            { '+', ("Oemplus",true) },
            { '[', ("OemOpenBrackets",false) },
            { '{', ("OemOpenBrackets",true) },
            { ']', ("OemCloseBrackets",false) },
            { '}', ("OemCloseBrackets",true) },
            { '\\', ("OemBackslash",false) },
            { '|', ("OemPipe",false) },
            { ';', ("OemSemicolon",false) },
            { ':', ("OemSemicolon",true) },
            { '\'', ("OemQuotes",false) },
            { '\"', ("OemQuotes",true) },
            { ',', ("OemComma",false) },
            { '<', ("OemComma",true) },
            { '.', ("OemPeriod",false) },
            { '>', ("OemPeriod",true) },
            { '/', ("OemQuestion",false) },
            { '?', ("OemQuestion",true) },
            { ' ', ("Space",false) }
        };
        public async Task<bool> RunCommand(string command) 
        {
            if (!isRunning) return false;
            command = command.ToUpper();
            async Task<bool> KeyDown(char whichKey)
            {
                Keys thisKey;
                if (Enum.TryParse<Keys>(whichKey.ToString(), out thisKey))
                {
                    NativeMethods.PostMessage(serverProcess.MainWindowHandle, (int)NativeMethods.KeyAction.WM_KEYDOWN, Convert.ToInt32(thisKey), (int)NativeMethods.getLParam(thisKey));
                            await Task.Delay(10);
                }
                else
                {
                    (string, bool) specialKeyTuple;
                    if (specialCharacters.TryGetValue(whichKey, out specialKeyTuple))
                    {
                        //if the shift key is required to make this particular character then use shift
                        if (specialKeyTuple.Item2)
                        {
                            //0x10 is the shift key
                            NativeMethods.keybd_event((byte)0x10, (byte)42, 0, 0);
                            await Task.Delay(50);
                            Keys specialKey;
                            Enum.TryParse<Keys>(specialKeyTuple.Item1, out specialKey);
                            NativeMethods.PostMessage(serverProcess.MainWindowHandle, (int)NativeMethods.KeyAction.WM_KEYDOWN, Convert.ToInt32(specialKey), (int)NativeMethods.getLParam(specialKey));
                            await Task.Delay(50);
                            NativeMethods.keybd_event((byte)0x10, (byte)42, (uint)NativeMethods.KEYEVENTTYPE.KEYEVENTF_KEYUP, 0);
                        }
                        else 
                        {
                            Keys specialKey;
                            Enum.TryParse<Keys>(specialKeyTuple.Item1, out specialKey);
                            NativeMethods.PostMessage(serverProcess.MainWindowHandle, (int)NativeMethods.KeyAction.WM_KEYDOWN, Convert.ToInt32(specialKey), (int)NativeMethods.getLParam(specialKey));
                        }
                    }
                    else 
                    {
                        MessageBox.Show("can't parse key + " + "\"" + whichKey + "\"");
                    }
                }
                return true;
            }
            for (int i = 0; i < command.Length; i++)
            {
                await KeyDown(command[i]);
            }
            //actually execute the command by sending the enter keystroke
            NativeMethods.PostMessage(serverProcess.MainWindowHandle, (int)NativeMethods.KeyAction.WM_KEYDOWN, Convert.ToInt32(Keys.Return), (int)NativeMethods.getLParam(Keys.Return));
            return true;
        }
        private void log(string message)
        {
                for (int i = 1; i < logSize; i++)
                {
                    serverLog[i - 1] = serverLog[i];
                }
                serverLog[logSize - 1] = message;
            LogHasChanged(this, EventArgs.Empty);
        }
        public event EventHandler LogChanged;

        void LogHasChanged(object sender, EventArgs e)
        {
            if (LogChanged != null)
            {
                LogChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler<CrossServerCommandEventArgs> CrossServerCommandHandler;

        void RunCrossServerCommand(object sender, CrossServerCommandEventArgs e)
        {
            if (CrossServerCommandHandler != null)
            {
                CrossServerCommandHandler(this, e);
            }
        }
        public class CrossServerCommandEventArgs : EventArgs 
        {
            public CrossServerCommandEventArgs(string _serverName, string _playerName, string _command) 
            {
                ServerName = _serverName;
                PlayerName = _playerName;
                Command = _command;
            }
            public string ServerName { get; set; }
            public string PlayerName { get; set; }
            public string Command { get; set; }
        }
        private void ServerProcess_Exited(object sender, EventArgs e)
        {
            if (startedOutputStreamRead)
            {
                serverProcess.CancelOutputRead();
                serverProcess.OutputDataReceived -= ServerOutputDataReceived;
                serverProcess.Exited -= ServerProcess_Exited;
                startedOutputStreamRead = false;
            }
            log("server stopped");
            isRunning = false;
        }
    }
}
