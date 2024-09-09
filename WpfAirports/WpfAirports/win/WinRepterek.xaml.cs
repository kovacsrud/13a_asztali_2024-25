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
using WpfAirports.model;

namespace WpfAirports.win
{
    /// <summary>
    /// Interaction logic for WinRepterek.xaml
    /// </summary>
    public partial class WinRepterek : Window
    {
        public WinRepterek(List<Airport> airports)
        {
            InitializeComponent();
            DataContext = airports;
            comboAirportCountryCodes.ItemsSource=getAirportCountryCodes();
            comboAirportCountryCodes.SelectedIndex=0;
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var airports=DataContext as List<Airport>;

            airportData.ItemsSource = null;

            var result = airports.FindAll(x=>x.AirportName.ToLower().Contains(textboxKeres.Text.ToLower()));

            if (result.Count > 0)
            {
                airportData.ItemsSource = result;
            } else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő nevű reptér!","Info");
            }


        }

        private void buttonVissza_Click(object sender, RoutedEventArgs e)
        {
            var airports = DataContext as List<Airport>;

            airportData.ItemsSource = airports;
        }

        private List<string> getAirportCountryCodes()
        {

            var airports = DataContext as List<Airport>;

            List<string> countryCodes = new List<string>();

            var osszesites = airports.ToLookup(x => x.AirportCountryCode).OrderBy(x=>x.Key);

            foreach (var i in osszesites)
            {
                countryCodes.Add(i.Key);
            }
            return countryCodes;
        }

        private void buttonCountryKeres_Click(object sender, RoutedEventArgs e)
        {
            var airports = DataContext as List<Airport>;

            var selectedCountryCode = comboAirportCountryCodes.SelectedItem.ToString();

            var results=airports.FindAll(x=>x.AirportCountryCode == selectedCountryCode);

            airportData.ItemsSource= results;
        }
    }
}
