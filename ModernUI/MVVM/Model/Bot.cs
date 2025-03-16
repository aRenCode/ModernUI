using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace ModernUI.MVVM.Model
{
    public static class Bot
    {


        public static ConnectionCredentials creds;

        public static TwitchClient client = new TwitchClient();

        private static ObservableCollection<Classes.ChatMessage> messages = new ObservableCollection<Classes.ChatMessage> { 
        new Classes.ChatMessage()
        };

        public static ObservableCollection<Classes.ChatMessage> Messages
        {
            get { return messages; }
            set
            {
                messages = value;
            }
        }


        //public string TwitchName { get; set; }

        private static string name { get; set; } //Connection creds only use statics

        public static string TwitchName
        {
            get { return name; }
            set { name = value; }
        }


        private static string token { get; set; } //Connection creds only use statics

        public static string Token
        {
            get { return token; }
            set { token = value; }
        }

        //public string Token { get; set; }


        /*
        public static Bot(string name, string token)
        { 
         TwitchName = name;
         Token = token;
         creds = new ConnectionCredentials(name, token);
         
        }*/
        

     
    }
}
