using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfKutyakEFUnique.mvvm.models;
using WpfKutyakEFUnique.mvvm.viewmodels;
using WpfKutyakEFUnique.mvvm.views;

namespace WpfKutyakEFUnique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new KutyaViewModel();
        }

        private void menuitemRendeles_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            KutyakView kutyak=new KutyakView(vm);
            kutyak.ShowDialog();
        }

        private void menuitemKutyanevek_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            KutyanevekView kutyanevek=new KutyanevekView(vm);
            kutyanevek.ShowDialog();
            

        }

        private void menuitemKutyafajtak_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}