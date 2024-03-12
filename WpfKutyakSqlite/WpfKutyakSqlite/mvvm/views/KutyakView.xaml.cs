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
    /// Interaction logic for KutyakView.xaml
    /// </summary>
    public partial class KutyakView : Window
    {
        public KutyakView(KutyaViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void datagridKutyak_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            vm.SelectedKutya = datagridKutyak.SelectedItem as Kutya;
            KutyakModView kutyakmod=new KutyakModView(vm,datagridKutyak,true);
            kutyakmod.ShowDialog();
        }
    }
}
