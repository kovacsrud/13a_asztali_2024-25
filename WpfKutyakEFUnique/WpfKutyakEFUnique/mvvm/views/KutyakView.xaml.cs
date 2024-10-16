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
using WpfKutyakEFUnique.mvvm.viewmodels;

namespace WpfKutyakEFUnique.mvvm.views
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

        private void buttonUj_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            KutyaEditView kutyaEdit=new KutyaEditView(vm);
            kutyaEdit.ShowDialog();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Módosítás
            var vm = DataContext as KutyaViewModel;
            KutyaEditView kutyaEdit = new KutyaEditView(vm,true);
            kutyaEdit.ShowDialog();
        }

        private void buttonTorles_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            var valasz=MessageBox.Show("Biztosan törli?","Törlés",MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (valasz == MessageBoxResult.OK && vm.SelectedKutya != null) { 
                vm.Kutyak.Remove(vm.SelectedKutya);
                vm.DbMentes();
            }
        }
    }
}
