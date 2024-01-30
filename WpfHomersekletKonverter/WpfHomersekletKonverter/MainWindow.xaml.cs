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

namespace WpfHomersekletKonverter
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

        private void buttonKonvertalas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (celsiusKivalaszt.IsChecked==true)
                {
                    konvertaltHomerseklet.Text = HomersekletAtvalto.FahrenheitToCelsius(Convert.ToDouble(homersekletErtek.Text)).ToString();
                } else
                {
                    konvertaltHomerseklet.Text = HomersekletAtvalto.CelsiusToFahrenheit(Convert.ToDouble(homersekletErtek.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }
    }
}
