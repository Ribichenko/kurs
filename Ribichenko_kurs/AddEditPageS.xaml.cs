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
    /// Логика взаимодействия для AddEditPageS.xaml
    /// </summary>
    public partial class AddEditPageS : Window
    {
        private Suplier _currentSup = new Suplier();
        public AddEditPageS(Suplier suplier)
        {
            InitializeComponent();
            if (suplier != null)
            {
                _currentSup = suplier;
            }
            DataContext = _currentSup;
        }
        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            if (_currentSup.Id_Suplier == 0)
            {
                TovarEntities.GetContext().Supliers.Add(new Suplier { Name = NameTb.Text.Trim(),  Email = EmailTb.Text.Trim(), Adress = AdressTb.Text.Trim(), PhoneNumber = PhoneTb.Text.Trim() });
            }
            TovarEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена");

            Close();
        }
        private void btnCancel_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
