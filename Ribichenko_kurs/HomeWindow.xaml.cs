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
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private int id;
        public HomeWindow()
        {
            InitializeComponent();
        }
        public HomeWindow(int Id_user)
        {
            InitializeComponent();
            id = Id_user;
            NickName.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Name;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Button_Sver_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Profile(id , this));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AAssort());
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Employ());
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Records());
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TheSupplier());
        }
    }
}
