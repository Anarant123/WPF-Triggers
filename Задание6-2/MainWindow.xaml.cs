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

namespace Задание6_2
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

        private void Button_Click_Open(object sender, RoutedEventArgs e)
        {
            tb1.IsEnabled = true;
            tb2.IsEnabled = true;
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            tb1.IsEnabled = false;
            tb2.IsEnabled = false;
        }
    }
}
