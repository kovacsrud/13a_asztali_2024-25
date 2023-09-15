using JackieStewart;
using Microsoft.Win32;
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

namespace WpfJackie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<RaceYear> RaceYears { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog()==true)
                {
                    JackieList jackieList = new JackieList(dialog.FileName);
                    RaceYears=jackieList.RaceYears;
                    datagridAdatok.ItemsSource = RaceYears;
                    comboYears.ItemsSource = RaceYears;
                    comboYears.SelectedIndex=0;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            datagridAdatok.ItemsSource=null;

            //var ev=Convert.ToInt32(textboxYear.Text);
            var ev = (int)comboYears.SelectedValue;
            var adatok=RaceYears.FindAll(x=> x.Year == ev);

            if (adatok.Count>0)
            {
                datagridAdatok.ItemsSource=adatok;
            } else
            {
                MessageBox.Show("Nincs ilyen adat!");
            }

        }

        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            datagridAdatok.ItemsSource = RaceYears;
        }
    }
}
