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
    /// Логика взаимодействия для UserRec.xaml
    /// </summary>
    public partial class UserRec : Page
    {
        private int id;
        public UserRec(int iduser)
        {
            InitializeComponent();
            id = iduser;
            MessageBox.Show("Привет ты хотел бы сделать заказ");
            EmailTb.Text = TovarEntities.GetContext().Users.FirstOrDefault(p => p.Id_user == id).Name;
        }

        private void btnReg_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы заказали");
            TovarEntities.GetContext().Records.Add(new Record { Name = NameTb.Text.Trim(), Login = EmailTb.Text.Trim() , Much = MuchTb.Text , Id_user = id }) ;
            TovarEntities.GetContext().SaveChanges();
        }
    }
}
