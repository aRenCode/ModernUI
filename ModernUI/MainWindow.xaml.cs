//using ModernUI.MVVM.Viewmodel;
using ModernUI.MVVM.Viewmodel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ModernUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var mainViewModel = new MainViewModel();
            //this.DataContext = mainViewModel;
            //Will show stuff when app is running but not in designer :(
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            

        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
            Trace.WriteLine("HO");

        }

        private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}