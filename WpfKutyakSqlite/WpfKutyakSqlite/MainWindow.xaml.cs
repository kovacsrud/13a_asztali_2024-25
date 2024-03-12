using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfKutyakSqlite.mvvm.viewmodels;
using WpfKutyakSqlite.mvvm.views;

namespace WpfKutyakSqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KutyaViewModel ViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new KutyaViewModel();
        }

        private void menuitemKutyanevek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                KutyanevekView kutyanevek = new KutyanevekView(ViewModel);
                kutyanevek.ShowDialog();
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void menuitemKutyafajtak_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                KutyafajtakView kutyafajtak = new KutyafajtakView(ViewModel);
                kutyafajtak.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void menuitemKutyak_Click(object sender, RoutedEventArgs e)
        {
            KutyakView kutyak = new KutyakView(ViewModel);
            kutyak.ShowDialog();
        }

        private void menuitemUjKutya_Click(object sender, RoutedEventArgs e)
        {
            KutyakModView kutyakModView = new KutyakModView(ViewModel,new DataGrid());
            kutyakModView.ShowDialog();
        }
    }
}