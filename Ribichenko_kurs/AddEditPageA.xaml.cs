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
    /// Interaction logic for AddEditPageA.xaml
    /// </summary>
    public partial class AddEditPageA : Window
    {
        private Product _currentProduct = new Product();
        public AddEditPageA(Product selectProduct)
        {
            InitializeComponent();
            if (selectProduct != null)
            {
                _currentProduct = selectProduct;
            }
            DataContext = _currentProduct;
            
        }

        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            if (_currentProduct.Id_product == 0)
            {
                TovarEntities.GetContext().Products.Add(new Product { Name = NameTb.Text.Trim(), Article = ArticleTb.Text.Trim(), Much = MuchTb.Text.Trim(), Price = PriceTb.Text.Trim(), Unit = UnitTb.Text.Trim() });
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
