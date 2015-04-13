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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private Page2 page2;
        public String imageName;
        private ImagePreview imagePreview;
        public Page3(Page2 page2)
        {
            InitializeComponent();
            this.page2 = page2;
            imageName = "Images/Stereogram1.png";
        }

        
         
          private void Image1_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Stereogram1.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }


        private void Image2_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Autostereogram_2box_600x400.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void Image3_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image3.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;

        }

        private void Image4_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image4.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void Image5_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image5.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void Image6_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image6.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void Image7_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image7.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void Image8_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image8.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(page2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nextpage = new Page4(imageName, this);
            this.NavigationService.Navigate(nextpage);
        }

        private void ImageControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var nextpage = new ImagePreview(imageName, this);
            this.NavigationService.Navigate(nextpage);
        }

        private void I1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Stereogram1.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Autostereogram_2box_600x400.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image3.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image4.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image5.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image6.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image7.png";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }

        private void I8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            imageName = "Images/Image8.jpg";
            bitmap.UriSource = new Uri(imageName, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();
            ImageControl.Source = bitmap;
        }
    
    }

}
