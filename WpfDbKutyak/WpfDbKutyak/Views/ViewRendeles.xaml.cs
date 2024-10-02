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
using WpfDbKutyak.Model;

namespace WpfDbKutyak.Views
{
    /// <summary>
    /// Interaction logic for ViewRendeles.xaml
    /// </summary>
    public partial class ViewRendeles : Window
    {
        public ViewRendeles()
        {
            InitializeComponent();
            datagridRendeles.ItemsSource = DbRepo.GetRendelesiAdatok();
        }

        private void buttonUjRendeles_Click(object sender, RoutedEventArgs e)
        {
            EditRendeles rendeles=new EditRendeles(datagridRendeles);
            rendeles.ShowDialog();
        }

        private void datagridRendeles_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selected = datagridRendeles.SelectedItem as Rendeles;
            EditRendeles rendeles = new EditRendeles(selected,datagridRendeles);
            rendeles.ShowDialog();
        }

        private void buttonTorolRendeles_Click(object sender, RoutedEventArgs e)
        {
            var selected = datagridRendeles.SelectedItem as Rendeles;
            if (selected != null) {
                DbRepo.TorolRendeles(selected.Id);
            }
            datagridRendeles.ItemsSource = DbRepo.GetRendelesiAdatok();
        }
    }
}
