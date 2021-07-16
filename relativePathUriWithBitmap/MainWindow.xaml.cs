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

namespace relativePathUriWithBitmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        string relPath = @"..\..\..\image.jpg";

        private void BtnAbs(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(System.IO.Path.GetFullPath(relPath)));
        }
        private void BtnRel(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(relPath, UriKind.Relative));
        }
    }
}
