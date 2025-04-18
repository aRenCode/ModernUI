﻿using ModernUI.Core;
using ModernUI.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ModernUI.MVVM.View;
using System.Collections.ObjectModel;

namespace ModernUI.MVVM.Viewmodel
{
     class BotViewModel : ObservableObject
    {
        public BotManager BotManager = new BotManager();


        public ICommand botCommand { get; set; }

        //public static string TwitchName { get; set; }

        private string _twitchName;

        public string TwitchName
        {
            get { return _twitchName; }
            set
            {
                _twitchName = value;
                OnPropertyChanged();
            }
        }



        //public static string Token { get; set; }

        private string _token;

        public string Token
        {
            get { return _token; }
            set
            {
                _token = value;
                OnPropertyChanged();
            }
        }



        //Some comment :)
        public BotViewModel()
        {
            botCommand = new RelayCommand(Change, CanClick);
        }

        private bool CanClick(object arg)
        {
            return true;
        }

        private void Change(object obj)
        {
            
            BotManager.SetBoth(Token, TwitchName);
            BotManager.Connect(true);
            
        }
    }
}
