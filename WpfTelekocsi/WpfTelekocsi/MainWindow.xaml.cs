using System.IO;
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

namespace WpfTelekocsi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Kocsi> Autok { get; set; } = new List<Kocsi>();
        
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                var adatok = File.ReadAllLines("telekocsi_autok.csv",Encoding.UTF7);

                for (int i = 1; i < adatok.Length; i++)
                {
                    Autok.Add(new Kocsi(adatok[i], ';'));
                }
                MessageBox.Show($"Betöltött adatsorok:{Autok.Count}");
                datagridKocsik.ItemsSource = Autok;
                comboTelepulesek.ItemsSource = GetTelepulesek();
                comboTelepulesek.SelectedIndex = 0;
                comboTelepulesekCel.ItemsSource = GetTelepulesek(true);
                comboTelepulesekCel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void buttonIndulasihelyKeres_Click(object sender, RoutedEventArgs e)
        {
            //Itt kell megvalósítani a keresést
            if (textboxIndulasihely.Text.Length>1)
            {
                var result = Autok.FindAll(x=>x.Indulas.ToLower()==textboxIndulasihely.Text.ToLower());
                if (result.Count>0)
                {
                    datagridKocsik.ItemsSource=result;
                }
                else
                {
                    MessageBox.Show($"Nem található:{textboxIndulasihely.Text}");
                }
            } else
            {
                MessageBox.Show("Adjon meg egy településnevet!");
            }
        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            datagridKocsik.ItemsSource = Autok;
        }

        private List<string> GetTelepulesek(bool cel=false)
        {
            var telepulesek = new List<string>();
            if (!cel)
            {
                var stat = Autok.ToLookup(x=>x.Indulas);
                foreach (var i in stat)
                {
                    telepulesek.Add(i.Key);
                }
            } else
            {
                var stat = Autok.ToLookup(x => x.Cel);
                foreach (var i in stat)
                {
                    telepulesek.Add(i.Key);
                }
            }

            return telepulesek;
        }
    }
}