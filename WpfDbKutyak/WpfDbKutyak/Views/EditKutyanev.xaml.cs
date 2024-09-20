using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Interaction logic for EditKutyanev.xaml
    /// </summary>
    public partial class EditKutyanev : Window
    {
        bool modosit = false;
        //Kutyanev aktKutyanev=new Kutyanev();
        public EditKutyanev()
        {
            InitializeComponent();
        }

        public EditKutyanev(Kutyanev kutyanev)
        {
            InitializeComponent();
            textblockFelirat.Text = "Kutyanév módosítás";
            textboxId.Text=kutyanev.Id.ToString();
            textboxKutyanev.Text = kutyanev.KutyaNev;
            //aktKutyanev = kutyanev;
            modosit = true;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (modosit) {

                DbRepo.ModositKutyanev(new Kutyanev {
                    Id=Convert.ToInt32(textboxId.Text),
                    KutyaNev=textboxKutyanev.Text
                });

            } else
            {
                DbRepo.UjKutyanev(new Kutyanev
                {
                    //Id = Convert.ToInt32(textboxId.Text),
                    KutyaNev = textboxKutyanev.Text
                });
            }
        }

        

        
    }
}
