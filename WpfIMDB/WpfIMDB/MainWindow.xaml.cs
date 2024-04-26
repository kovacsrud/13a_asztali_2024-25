using Microsoft.Win32;
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
using WpfIMDB.model;
using WpfIMDB.views;

namespace WpfIMDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".csv|*.csv";

            if(dialog.ShowDialog() == true)
            {
                try
                {
                    DataContext = new MovieList(dialog.FileName,';');
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);                    
                }
            }


        }

        private void menuitemSzuresEv_Click(object sender, RoutedEventArgs e)
        {
            var lista=DataContext as MovieList;

            SzuresEv szuresEv = new SzuresEv(lista);
            szuresEv.ShowDialog();
        }

        private void menuitemSzuresKategoria_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemSzuresRating_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}