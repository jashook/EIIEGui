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

namespace SDGUI4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _mainFrame.Navigate(new Page1());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HelpWindow help = new HelpWindow(this);
            help.Show();
        }

        private void _mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
