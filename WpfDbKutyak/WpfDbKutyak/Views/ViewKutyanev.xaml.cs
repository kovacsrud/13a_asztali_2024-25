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
using System.Data.SQLite;

namespace WpfDbKutyak.Views
{
    /// <summary>
    /// Interaction logic for ViewKutyanev.xaml
    /// </summary>
    public partial class ViewKutyanev : Window
    {
        //private string connectionString = "Data Source=kutyak.db";
        public ViewKutyanev()
        {
            InitializeComponent();
            datagridKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
        }

        

        private void buttonUjkutyanev_Click(object sender, RoutedEventArgs e)
        {
            EditKutyanev editKutyanev = new EditKutyanev();
            editKutyanev.ShowDialog();
        }

        private void datagridKutyanevek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var aktKutyanev=datagridKutyanevek.SelectedItem as Kutyanev;

            EditKutyanev editKutyanev=new EditKutyanev(aktKutyanev);
            editKutyanev.ShowDialog();

        }
    }
}
