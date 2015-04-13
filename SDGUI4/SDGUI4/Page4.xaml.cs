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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private Page3 page3;
        public String imageName;
        public Page4(String imageName, Page3 page3)
        {
            InitializeComponent();
            this.page3 = page3;
            this.imageName = imageName;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var nextpage = new Page5(imageName, this);
            this.NavigationService.Navigate(nextpage);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(page3);

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
