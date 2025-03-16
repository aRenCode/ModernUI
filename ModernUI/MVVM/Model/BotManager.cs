using ModernUI.Classes;
using ModernUI.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace ModernUI.MVVM.Model
{
    class BotManager : ObservableObject
    {
        
        public Classes.ChatMessage chatMsg { get; set; } = new Classes.ChatMessage();

        private  ObservableCollection<Classes.ChatMessage> messages = new ObservableCollection<Classes.ChatMessage> {};

        public  ObservableCollection<Classes.ChatMessage> Messages
        {
            get { return Bot.Messages; }
            set
            {
                messages = value;
                OnPropertyChanged();
            }
        }


        // Value setters and getters
        public  void SetBoth(string token, string twitchName) {
            Bot.TwitchName = twitchName;
            Bot.Token = token;
            Bot.creds = new ConnectionCredentials(Bot.TwitchName, Bot.Token);
            //bot = new Bot(twitchName, token);
        }

        public  void SetToken(string token) {Bot.Token = token; }

        public void SetTwitchName(string twichName) { Bot.TwitchName = twichName; }
        public  void ChangeToken(string newToken) => Bot.Token = newToken;

        public string GetToken() =>  Bot.Token;

        public void ChangeTwitchName(string newName) => Bot.TwitchName = newName;

        public  string GetTwitchName() => Bot.TwitchName;



        //Connection methods

        public void Connect(bool logging)
        {
            
            Bot.client.Initialize(Bot.creds, GetTwitchName());
           
            
            if (logging)
                Bot.client.OnLog += Client_Log;

            Bot.client.OnConnected += Client_OnConnected;

            Bot.client.OnMessageReceived += Client_OnMessageReceived;
            Bot.client.Connect();

            

           
            
        }

        private void Client_OnMessageReceived1(object? sender, OnMessageReceivedArgs e)
        {
            throw new NotImplementedException();
        }

        private void Client_Log(object? sender, OnLogArgs e)
        {
            Trace.WriteLine(e.Data);
        }

        public void Disonnect()
        {
            Bot.client.Disconnect();
        }


      


        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            var chatMsg2 = new Classes.ChatMessage
            {
                Username = $"{e.ChatMessage.DisplayName}: ",
                Message = e.ChatMessage.Message,
                ColorValue = e.ChatMessage.ColorHex
            };

            //sadasd
            //Bot.Messages.Add(chatMsg2);
            Application.Current.Dispatcher.Invoke(() =>
            {
                Bot.Messages.Add(chatMsg2);
            });

            Trace.WriteLine(Bot.Messages.Count);
            Trace.WriteLine(chatMsg2.Username);

            foreach (var chatMsg in Bot.Messages)
                Trace.WriteLine(chatMsg.Message);
            OnPropertyChanged("Messages");
            
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Bot.client.SendMessage(Bot.client.JoinedChannels.FirstOrDefault(), "Wassup!");
        }




    }
}
