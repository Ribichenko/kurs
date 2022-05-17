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
    /// Логика взаимодействия для AddEditPageE.xaml
    /// </summary>
    public partial class AddEditPageE : Window
    {
        private Employ _currentEmploy = new Employ();
        public AddEditPageE(Employ selectEm)
        {
            InitializeComponent();
           
            if (selectEm != null)
            {
                _currentEmploy = selectEm;
            }
            DataContext = _currentEmploy;
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            if (_currentEmploy.Id_employ == 0)
            {
                TovarEntities.GetContext().Employs.Add(new Employ {FIO = FIOTb.Text.Trim(), Position = PositionTb.Text.Trim(), Email = EmailTb.Text.Trim(), Adress = AdressTb.Text.Trim(), PhoneNumber = PhoneTb.Text.Trim()});
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
