using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TerrariaMultiServer
{
    public class TerrariaConfig
    {
        public Dictionary<string, string> config;
        /*
        public string port;
        public string maxplayers;//1 to 255
        public string password;
        public string world;//path to the worldfile to autostart the server with
        public string autocreate;//1(small), 2(medium), and 3(large)
        public string banlist;//path to the banlist
        public string worldname;//name of world if using autocreate
        public string worldpath;
        public string secure;//0,1
        public string upnp;//0,1
        public string ip;
        public string seed;
        public string difficulty;//0(classic), 1(expert), 2(master), 3(journey)
        public string motd;
        public string language;//English = en-US, German = de-DE, Italian = it-IT, French = fr-FR, Spanish = es-ES, Russian = ru-RU, Chinese = zh-Hans, Portuguese = pt-BR, Polish = pl-PL
        public string priority;//0(Realtime), 1(High), 2(AboveNormal), 3(Normal), 4(BelowNormal), 5(Idle)
        public string npcstream;//default is 60 (range 0-120)
        */
        void initializeConfig() 
        {
            config = new Dictionary<string, string>();
            config.Add("port", "");
            config.Add("maxplayers", "");
            config.Add("password", "");
            config.Add("world", "");
            config.Add("autocreate", "");
            config.Add("banlist", "");
            config.Add("worldname", "");
            config.Add("worldpath", "");
            config.Add("secure", "");
            config.Add("upnp", "");
            config.Add("ip", "");
            config.Add("seed", "");
            config.Add("difficulty", "");
            config.Add("motd", "");
            config.Add("language", "");
            config.Add("priority", "");
            config.Add("npcstream", "");
        }
        public TerrariaConfig() 
        {
            initializeConfig();
        }
        public TerrariaConfig(string configFilePath) 
        {
            initializeConfig();
            //allProperties = Type.GetType("TerrariaConfig").GetProperties();
            if (File.Exists(configFilePath))
            {
                //read all the config files info and parse it
                string[] serverConfigFileLines = File.ReadAllLines(configFilePath);
                for (int i = 0; i < serverConfigFileLines.Length; i++)
                {
                    string[] splitLine = serverConfigFileLines[i].Split('=');
                    if (splitLine.Length > 1)
                    {
                        if (config.ContainsKey(splitLine[0])) config[splitLine[0]] = splitLine[1];
                    }
                }
            }
            else 
            {
                MissingFilesDialogue missingFilesDialogue = new MissingFilesDialogue(new string[] {"serverconfig.txt"});
                missingFilesDialogue.ShowDialog();
            }
        }
    }
}
