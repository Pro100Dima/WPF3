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
using WpfEquipments.DAL.Module;

namespace WpfEquipments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame mf;
        private mcs db = new mcs();
        public MainWindow()
        {
            InitializeComponent();
            mf = MainFrame;
        }

        private void miManufactures_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PageManufactures.xaml",
                UriKind.RelativeOrAbsolute);//Uri - zhdet class soderzhawiy ssylki
        }

        private void miAddManufactures_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PageAddManufacture.xaml",
                UriKind.RelativeOrAbsolute);//Uri - zhdet class soderzhawiy ssylki
        }

        private void miModel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PageModels.xaml",
               UriKind.RelativeOrAbsolute);//Uri - zhdet class soderzhawiy ssylki
        }
    }
}
