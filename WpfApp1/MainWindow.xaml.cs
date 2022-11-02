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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }
        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
