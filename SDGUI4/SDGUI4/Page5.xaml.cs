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
using System.Diagnostics;

namespace SDGUI4
{
    /// <summary>
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        private Page4 page4;
        public String imageName;
        public Page5(String imageName, Page4 page4)
        {
            InitializeComponent();
            this.page4 = page4;
            imageName = imageName;
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "HelloWorld.exe"; //This is just an example file to open... could open others as well
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.

            //I think I need to use background worker to stop this application while the other runs...not entirely sure how to do this/if this is right but I found documentation on it which is promising


        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(page4);

        }
    }

    
}
