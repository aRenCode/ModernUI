using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TwitchLib.Client.Events;

namespace ModernUI.MVVM.Model
{
    class BotManager
    {
        public static Bot bot;


        // Value setters and getters
        public static void SetBoth(string token, string twitchName) {
            bot = new Bot(twitchName, token);
        }

        public static void SetToken(string token) {bot.Token = token; }

        public static void SetTwitchName(string twichName) { bot.TwitchName = twichName; }
        public static void ChangeToken(string newToken) => bot.Token = newToken;

        public static string GetToken() =>  bot.Token;

        public static void ChangeTwitchName(string newName) => bot.TwitchName = newName;

        public static string GetTwitchName() => bot.TwitchName;



        //Connection methods

        public static void Connect(bool logging)
        {
            
            bot.client.Initialize(bot.creds, GetTwitchName());
           

            if (logging)
                bot.client.OnLog += Client_Log;

            bot.client.Connect();
        }

        private static void Client_Log(object? sender, OnLogArgs e)
        {
            Trace.WriteLine(e.Data);
        }

        public static void Disonnect()
        {
            bot.client.Disconnect();
        }



    }
}
