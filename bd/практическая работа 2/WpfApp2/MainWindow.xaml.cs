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


        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // создаем рандом 
            Random rnd = new Random();
            // next(256) он запишет значение от 0 до 255 
            int a = rnd.Next(256);
            int b = rnd.Next(256);
            int c = rnd.Next(256);
            int d = rnd.Next(256);
            // оно хотело получить свой byte я дал byte, int оно не хотело хз почему 
            byte color1 = Convert.ToByte(a);
            byte color2 = Convert.ToByte(b);
            byte color3 = Convert.ToByte(c);
            byte color4 = Convert.ToByte(d);
            // тут так надо
            button3.Background = new SolidColorBrush(Color.FromArgb(color1, color2, color3, color4));
        }
    }
}
