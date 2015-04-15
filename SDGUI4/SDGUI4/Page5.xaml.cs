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
using System.Threading;
using System.IO;

namespace SDGUI4
{
    /// <summary>
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        private Page4 page4;
        public String ImageName;
        private string OpenGLArguments;
        private string OpenGLExeName;
        private string EyeTrackerExeName;
        private Page1 page1;

        public Page5(String imageName, Page4 page4)
        {
            InitializeComponent();
            this.page4 = page4;
            ImageName = imageName;

            string[] lines = File.ReadAllLines("install.dat");

            if (lines.Count() != 4)
            {
               throw new Exception("Error, install.dat file has been corrupted, please reinstall");
            }

            OpenGLExeName = lines[0];
            EyeTrackerExeName = lines[1];

            StringBuilder argument_builder = new StringBuilder();
            argument_builder.Append(ImageName);
            argument_builder.Append(" ");
            argument_builder.Append(lines[3]);
            argument_builder.Append(" ");
            argument_builder.Append(lines[4]);

            OpenGLArguments = argument_builder.ToString();
        }

        public Page5(Page1 page1)
        {
            InitializeComponent();
            this.page1 = page1;
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            new Thread(new ThreadStart( ( ) =>  
            {
               // Let the server (Eye Tracker) start before we open the opengl code.
               Thread.Sleep(500);

               Process process = new Process();
               // Configure the process using the StartInfo properties.
               process.StartInfo.FileName = OpenGLExeName; //This is just an example file to open... could open others as well
               process.StartInfo.Arguments = OpenGLArguments;
               process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
               process.Start();
               process.WaitForExit(); // Waits here for the process to exit.

               // OpenGL Process has finished.
            }));

            new Thread(new ThreadStart(() =>
            {
               Process process = new Process();
               // Configure the process using the StartInfo properties.
               process.StartInfo.FileName = EyeTrackerExeName; //This is just an example file to open... could open others as well
               process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
               process.Start();
               process.WaitForExit(); // Waits here for the process to exit.

               // EyeTracker has finished.

            }));

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(page4);

        }
    }

    
}
