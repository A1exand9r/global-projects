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

namespace WpfApp1
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

        public void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        internal void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addition_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            resulttextblock.Text = Convert.ToString(num1 + num2);
        }

        private void difference_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            resulttextblock.Text = Convert.ToString(num1 - num2);
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            resulttextblock.Text = Convert.ToString(num1 * num2);
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remainsd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void degree_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
