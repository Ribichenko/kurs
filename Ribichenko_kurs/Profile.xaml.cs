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

namespace Ribichenko_kurs
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        private int id;
        private HomeWindow main;
        private UserWindow UserWindow;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(int iduser , HomeWindow home)
        {
            InitializeComponent();
            id = iduser;
            main = home;
            MessageBox.Show($"Добро пожалавать");
            NameTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Name;
            EmailTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Email;
            PhoneTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).PhoneNumber;
            
        }
        public Profile(int iduser, UserWindow user)
        {
            InitializeComponent();
            id = iduser;
            UserWindow = user;
            MessageBox.Show($"Добро пожалавать");
            NameTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Name;
            EmailTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Email;
            PhoneTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).PhoneNumber;

        }

        private void btnPass_click(object sender, RoutedEventArgs e)
        {
            PasswordTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Password;

        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Name = NameTb.Text ;
            TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Email = EmailTb.Text;
            TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).PhoneNumber = PhoneTb.Text;
            if (PasswordTb.Text == "")
            {
                PasswordTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Password;
            }
            else
            {
                TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Password = PasswordTb.Text;
            }
            
            TovarEntities.GetContext().SaveChanges();
            MessageBox.Show("Вы сохранены");
            if (id == 1 || id == 2)
            {
                HomeWindow home = new HomeWindow(id);
                home.Show();
            }
            else
            {
                UserWindow user = new UserWindow(id);
                user.Show();
            }
            if (main != null)
            {
                main.Close();
            }
        }

        private void btnEXit_click(object sender, RoutedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            if (main != null)
            {
                main.Close();
            }
        }
    }
}
