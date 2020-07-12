using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaMultiServer
{
    public class AppConfig
    {
        //general addon functionality settings
        public bool allowCrossServerChat;
        public bool doCrossServerPlayingCommand;
        public bool allowMobileAppControl;
        public bool autoUpdateServer;
        //chat command settings
        //the bool is to check if a user is allowed to run that chat command or not
        public Dictionary<string, bool> config;
        public AppConfig() 
        {
            config = new Dictionary<string, bool>();
            config.Add("exit", false);
            config.Add("exit-nosave", false);
            config.Add("save", false);
            config.Add("kick", false);
            config.Add("ban", false);
            config.Add("password", false);
            config.Add("setpassword", false);
            config.Add("version", false);
            config.Add("time", false);
            config.Add("port", false);
            config.Add("maxplayers", false);
            config.Add("motd", false);
            config.Add("setmotd", false);
            config.Add("dawn", false);
            config.Add("noon", false);
            config.Add("dusk", false);
            config.Add("midnight", false);
            config.Add("settle", false);
            config.Add("seed", false);
            config.Add("playing", false);
        }
    }
}