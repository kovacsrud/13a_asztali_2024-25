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
using WpfKutyakEFUnique.mvvm.models;
using WpfKutyakEFUnique.mvvm.viewmodels;

namespace WpfKutyakEFUnique.mvvm.views
{
    /// <summary>
    /// Interaction logic for KutyaEditView.xaml
    /// </summary>
    public partial class KutyaEditView : Window
    {
        bool modosit = false;
        public Kutya AktKutya { get; set; } = new Kutya();
        public KutyaViewModel KutyaViewModel { get; set; }


        public KutyaEditView(KutyaViewModel vm,bool modosit=false)
        {
            InitializeComponent();
            this.modosit = modosit;
            KutyaViewModel = vm;
            DataContext = this;

            if (modosit) {
                AktKutya = KutyaViewModel.SelectedKutya;
            }
        }

        private void buttonMent_Click(object sender, RoutedEventArgs e)
        {
            if (modosit)
            {
                KutyaViewModel.DbMentes();
            } else
            {
                KutyaViewModel.Kutyak.Add(AktKutya);
                KutyaViewModel.DbMentes();
            }
        }
    }
}
