using ModernUI.MVVM.Model;
using ModernUI.MVVM.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUI.MVVM.View
{
    /// <summary>
    /// Interaction logic for BotView.xaml
    /// </summary>
    public partial class BotView : UserControl
    {
        public BotView()
        {
            InitializeComponent();
        }

       

        private void TwitchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           //BotViewModel.TwitchName = TwitchTextBox.Text;
           //MessageBox.Show(TwitchTextBox.Text);
           
        }

        private void TokenTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //BotViewModel.Token = TokenTextBox.Text;

            
        }
    }
}
