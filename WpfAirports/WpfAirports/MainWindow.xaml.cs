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
using WpfAirports.model;
using WpfAirports.win;

namespace WpfAirports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Airport> Airports { get; set; } = new List<Airport>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemNevjegy_Click(object sender, RoutedEventArgs e)
        {
            WinNevjegy winNevjegy = new WinNevjegy();
            winNevjegy.ShowDialog();
        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "*csv fájlok|*.csv|minden fájl|*.*"; ;

            try
            {
                if (dialog.ShowDialog()==true)
                {
                    AirportList airportList = new AirportList(dialog.FileName, ';');
                    Airports=airportList.Airports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Hiba");                
            }

        }
    }
}