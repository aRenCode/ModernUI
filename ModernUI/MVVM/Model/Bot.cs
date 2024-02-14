using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace ModernUI.MVVM.Model
{
    public class Bot
    {


        public ConnectionCredentials creds;

        public TwitchClient client = new TwitchClient();


        //public string TwitchName { get; set; }

        private static string name { get; set; } //Connection creds only use statics

        public string TwitchName
        {
            get { return name; }
            set { name = value; }
        }


        private static string token { get; set; } //Connection creds only use statics

        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        //public string Token { get; set; }


        public Bot(string name, string token)
        { 
         this.TwitchName = name;
         this.Token = token;
         creds = new ConnectionCredentials(name, token);
         
        }
        
    }
}
