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
    /// Interaction logic for Employ.xaml
    /// </summary>
    public partial class Employ : Page
    {
        private Employ _employ;
        public Employ()
        {
            InitializeComponent();
            DataContext = _employ;
        }
        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            AddEditPageE pageE = new AddEditPageE(null);
            pageE.Show();
        }
        private void DGridRecords_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TovarEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridRecord.ItemsSource = TovarEntities.GetContext().Employs.ToList();
            }
        }

        private void BtnEdit1_click(object sender, RoutedEventArgs e)
        {
            AddEditPageE pageA = new AddEditPageE((sender as Button).DataContext as Employ);
            pageA.Show();
        }

        private void btnDel_click(object sender, RoutedEventArgs e)
        {
            var rec = DGridRecord.SelectedItems.Cast<Employ>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие элементы {rec.Count()}?", "Alarm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                TovarEntities.GetContext().Employs.RemoveRange(rec);

                TovarEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы удалили");
                DGridRecord.ItemsSource = TovarEntities.GetContext().Employs.ToList();
            }
        }
    }
}
