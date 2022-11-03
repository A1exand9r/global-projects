using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace WpfApp2
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

        private void togbut_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("ToggleButton в положении", Convert.ToString(togbut.IsChecked));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            byte color1 = Convert.ToByte(rnd.Next(256));
            byte color2 = Convert.ToByte(rnd.Next(256));
            byte color3 = Convert.ToByte(rnd.Next(256));
            byte color4 = Convert.ToByte(rnd.Next(256));
            button3.Background = new SolidColorBrush(Color.FromArgb(color1, color2, color3, color4));
        }

    }
}
