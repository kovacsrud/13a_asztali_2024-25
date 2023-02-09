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

namespace WpfSzorzas
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textboxA.Text);
                double b = Convert.ToDouble(textboxB.Text);

                double eredmeny = a * b;

                labelEredmeny.Content = eredmeny;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A mezőkben számot kell megadni!","Hiba",MessageBoxButton.OK,MessageBoxImage.Warning);                
            }
          

        }
    }
}
