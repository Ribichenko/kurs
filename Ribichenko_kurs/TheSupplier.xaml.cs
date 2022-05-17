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
    /// Interaction logic for TheSupplier.xaml
    /// </summary>
    public partial class TheSupplier : Page
    {
        private Suplier suplier;
        public TheSupplier()
        {
            InitializeComponent();
            DataContext = suplier;
            DGridRecords.ItemsSource = TovarEntities.GetContext().Supliers.ToList();
        }
        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditPageS pageS = new AddEditPageS(null);
            pageS.Show();
        }
        private void DGridRecords_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                 TovarEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                 DGridRecords.ItemsSource = TovarEntities.GetContext().Supliers.ToList();
            }
        }

        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            AddEditPageS pageS = new AddEditPageS((sender as Button).DataContext as Suplier);
            pageS.Show();
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
