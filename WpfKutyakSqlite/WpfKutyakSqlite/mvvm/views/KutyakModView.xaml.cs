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
using WpfKutyakSqlite.mvvm.models;
using WpfKutyakSqlite.mvvm.viewmodels;

namespace WpfKutyakSqlite.mvvm.views
{
    /// <summary>
    /// Interaction logic for KutyakModView.xaml
    /// </summary>
    public partial class KutyakModView : Window
    {
        public Kutya AktualisKutya { get; set; }
        public KutyaViewModel ViewModel { get; set; }
        public bool IsModositas { get; set; }

        private DataGrid grid;
        public KutyakModView(KutyaViewModel vm,DataGrid grid,bool modositas=false)
        {
            InitializeComponent();
            ViewModel= vm;
            this.grid = grid;
            DataContext = this;
            IsModositas = modositas;
            if (modositas)
            {
                AktualisKutya = vm.SelectedKutya;

            } else
            {
                AktualisKutya = new Kutya {
                    Fajtaid = 1,
                    Nevid=1,
                    Eletkor=0,
                    Utolsoell=DateTime.Now,

                };
            }
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            if (IsModositas)
            {
                ViewModel.DbMentes();
                grid.Items.Refresh();
            }
            else {
                ViewModel.Kutyak.Add(AktualisKutya);
                ViewModel.DbMentes();
            }
            
        }
    }
}
