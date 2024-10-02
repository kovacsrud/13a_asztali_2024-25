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
    /// Interaction logic for EditRendeles.xaml
    /// </summary>
    public partial class EditRendeles : Window
    {
        DataGrid dataGrid;
        bool modosit=false;
        Rendeles rendeles;
        public EditRendeles(DataGrid dataGrid)
        {
            InitializeComponent();
            comboKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            comboKutyanevek.SelectedIndex = 0;
            comboKutyafajtak.ItemsSource = DbRepo.GetKutyafajtak();
            comboKutyafajtak.SelectedIndex = 0;
            this.dataGrid = dataGrid;
        }

        public EditRendeles(Rendeles rendeles, DataGrid dataGrid)
        {
            InitializeComponent();
            modosit = true;
            this.rendeles = rendeles;
            comboKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            comboKutyanevek.SelectedValue = rendeles.NevId;
            comboKutyafajtak.ItemsSource=DbRepo.GetKutyafajtak();
            comboKutyafajtak.SelectedValue = rendeles.FajtaId;
            textboxEletkor.Text = rendeles.Eletkor.ToString();
            textboxUtolsoEll.Text=rendeles.UtolsoEll.ToString();
            this.dataGrid = dataGrid;
        }

        private void buttonRogzit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (modosit)
                {
                    //Adat módosítása
                    Rendeles rendeles = new Rendeles();
                    rendeles.Id=this.rendeles.Id;
                    rendeles.NevId = (int)comboKutyanevek.SelectedValue;
                    rendeles.FajtaId = (int)comboKutyafajtak.SelectedValue;
                    rendeles.Eletkor = Convert.ToInt32(textboxEletkor.Text);
                    rendeles.UtolsoEll = textboxUtolsoEll.Text;

                    DbRepo.ModositRendelesiAdat(rendeles);
                    dataGrid.ItemsSource = DbRepo.GetRendelesiAdatok();

                } else {
                    //Új adat felvétele
                    Rendeles rendeles = new Rendeles();
                    rendeles.NevId = (int)comboKutyanevek.SelectedValue;
                    rendeles.FajtaId = (int)comboKutyafajtak.SelectedValue;
                    rendeles.Eletkor = Convert.ToInt32(textboxEletkor.Text);
                    rendeles.UtolsoEll = textboxUtolsoEll.Text;

                    DbRepo.UjRendelesiAdat(rendeles);
                    dataGrid.ItemsSource = DbRepo.GetRendelesiAdatok();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
