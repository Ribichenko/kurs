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
    /// Interaction logic for Records.xaml
    /// </summary>
    public partial class Records : Page
    {
        public Records()
        {
            InitializeComponent();
            DGridRecords.ItemsSource = TovarEntities.GetContext().Records.ToList();
        }
        private void DGridRecords_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                //  AutoLandEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                //  DGridRecords.ItemsSource = AutoLandEntities.GetContext().Records.ToList();
            }
        }
    }
}
