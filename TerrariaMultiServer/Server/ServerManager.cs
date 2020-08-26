using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace TerrariaMultiServer
{
    class ServerManager
    {
        public BindingList<Server> serverList { get; private set; }
        public AppConfig appConfig;

        public ServerManager() 
        {
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\appconfig.json"))
            {
                string appConfigFileContent = File.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\appconfig.json");
                appConfig = JsonConvert.DeserializeObject<AppConfig>(appConfigFileContent);
            }
            else
            {
                appConfig = new AppConfig();
                File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\appconfig.json", "{}");
            }
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\serverlist.json"))
            {
                string serverListFileContent = File.ReadAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\serverlist.json");
                serverList = JsonConvert.DeserializeObject<BindingList<Server>>(serverListFileContent);
                foreach (Server server in serverList)
                {
                    server.CrossServerCommandHandler += Server_CrossServerCommandHandler;
                    server.autoUpdate = appConfig.autoUpdateServer;
                }
            }
            else 
            {
                serverList = new BindingList<Server>();
                File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\serverlist.json", "{}");
            }

        }

        private void Server_CrossServerCommandHandler(object sender, Server.CrossServerCommandEventArgs e)
        {
            //we need to check if there are parameters to this command
            string[] commandSplitFromArguments = e.Command.Split(' ');
            if (commandSplitFromArguments.Length <= 0) return;
            //if the command is a message then see if cross server messages are enabled
            if (commandSplitFromArguments[0] == "crossServerMessage")
            {
                if (appConfig.allowCrossServerChat)
                {
                    foreach (Server server in serverList)
                    {
                        if (server.serverName != e.ServerName)
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                            server.RunCommand("say " + e.PlayerName + ":" + string.Join(" ", commandSplitFromArguments, 1, commandSplitFromArguments.Length - 1));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                    }
                }
            }
            //if the command exists then see if the player is allowed to execute it
            else if (appConfig.config.ContainsKey(commandSplitFromArguments[0])) 
            {
                //if the command has arguments then see if we are allowed to run that command if it has arguments
                if ((commandSplitFromArguments.Length > 1))
                {
                    //edge cases for password and motd set
                    if (commandSplitFromArguments[0] == "password" || commandSplitFromArguments[0] == "motd")
                    {
                        //if they are allowed to run this specific command with arguments then execute it otherwise ignore it
                        if (appConfig.config["set" + commandSplitFromArguments[0]])
                        {
                            //get the server that the command needs ran on
                            foreach (Server server in serverList)
                            {
                                if (server.serverName == e.ServerName)
                                {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                    server.RunCommand(commandSplitFromArguments[0] + " " + string.Join(" ", commandSplitFromArguments, 1, commandSplitFromArguments.Length - 1));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    //if the command isn't a special case then see if we are allowed to run it
                    //if we are then run that command with the arguments
                    else if (appConfig.config[commandSplitFromArguments[0]])
                    {
                        foreach (Server server in serverList)
                        {
                            if (server.serverName == e.ServerName)
                            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                server.RunCommand(commandSplitFromArguments[0] + " " + string.Join(" ", commandSplitFromArguments, 1, commandSplitFromArguments.Length - 1));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                return;
                            }
                        }
                        return;
                    }
                    else 
                    {
                        return;
                    }
                }
                else if (commandSplitFromArguments.Length == 1) 
                {
                    if (appConfig.config.ContainsKey(commandSplitFromArguments[0])) 
                    {
                        //if the user is allowed to execute that command then run it and output the data
                        if (appConfig.config[commandSplitFromArguments[0]]) 
                        {
                            foreach (Server server in serverList)
                            {
                                if (server.serverName == e.ServerName)
                                {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                    server.RunCommand(commandSplitFromArguments[0]);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SaveData() 
        {
            File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\serverlist.json", JsonConvert.SerializeObject(serverList, Formatting.Indented));
            File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\appconfig.json", JsonConvert.SerializeObject(appConfig, Formatting.Indented));
        }
        public void AddServer() 
        {
            FormAddServer formAddServer = new FormAddServer();
            formAddServer.ShowDialog();
            if (formAddServer.DialogResult == DialogResult.OK)
            {
                //check server list for a duplicate server directory
                if (DoesServerDirectoryAlreadyExist(formAddServer.formData.serverDirectory)) return;
                serverList.Add(new Server(formAddServer.formData.serverName, formAddServer.formData.serverDirectory,appConfig.autoUpdateServer));
            }
        }
        public bool DoesServerDirectoryAlreadyExist(string directory) 
        {
            foreach (Server server in serverList)
            {
                if (server.serverDirectory == directory)
                {
                    MessageBox.Show("This server has already been added and is named " + "\"" + server.serverName + "\"");
                    return true;
                }
            }
            return false;
        }
        public void RemoveServer(string serverName) 
        {
            for (int i = 0; i < serverList.Count; i++)
            {
                if (serverList[i].serverName == serverName) 
                {
                    serverList.RemoveAt(i);
                    return;
                }
            }
        }
        public void RemoveServerAt(int index) 
        {
            serverList.RemoveAt(index);
        }
        public void StartServerAt(int index) 
        {
            serverList[index].StartServer();
        }
        public void StopServerAt(int index) 
        {
            serverList[index].StopServer();
        }
    }
}
