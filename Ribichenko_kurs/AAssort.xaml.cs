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
    /// Interaction logic for AAssort.xaml
    /// </summary>
    public partial class AAssort : Page
    {
        private Product _product;
        public AAssort()
        {
            InitializeComponent();
            DataContext = _product;
            DGridRecords.ItemsSource = TovarEntities.GetContext().Products.ToList();
        }

        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditPageA pageA = new AddEditPageA(null);
            pageA.Show();
        }
        private void DGridRecords_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TovarEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridRecords.ItemsSource = TovarEntities.GetContext().Products.ToList();
            }
        }

        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditPageA pageA = new AddEditPageA((sender as Button).DataContext as Product);
            pageA.Show();
        }
        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var rec = DGridRecords.SelectedItems.Cast<Employ>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие элементы {rec.Count()}?", "Alarm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                TovarEntities.GetContext().Employs.RemoveRange(rec);

                TovarEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы удалили");
                DGridRecords.ItemsSource = TovarEntities.GetContext().Employs.ToList();
            }
        }
    }
}
