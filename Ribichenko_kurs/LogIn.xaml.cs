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
using System.Windows.Shapes;

namespace Ribichenko_kurs
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Sver_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            LogIn min2 = new LogIn();
            min2.Show();
            Close();
        }
        private void reg_link_Click(object sender, RoutedEventArgs e)
        {

            MainWindow min1 = new MainWindow();
            min1.Show();
            Close();
        }

        private void sbros_link_Click(object sender, RoutedEventArgs e)
        {
            Sbros min3 = new Sbros();
            min3.Show();
            Close();
        }
    }
}
