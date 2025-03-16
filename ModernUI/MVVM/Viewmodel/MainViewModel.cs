using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernUI.Core;

namespace ModernUI.MVVM.Viewmodel
{
     class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BotViewCommand { get; set; }

        public RelayCommand ChatViewCommand { get; set; }

       

        public HomeViewModel HomeVM { get; set; }

        public BotViewModel BotVM { get; set; }

        public ChatViewModel ChatVM { get; set; }

        private object _currentView;

        public object CurrentView { 
        get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            BotVM = new BotViewModel();
            ChatVM = new ChatViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(x => { 
            CurrentView = HomeVM;
            });

            BotViewCommand = new RelayCommand(x => {
                CurrentView = BotVM;
            });

            ChatViewCommand = new RelayCommand(x =>
            {
                CurrentView = ChatVM;
            });
        }
    }
}
