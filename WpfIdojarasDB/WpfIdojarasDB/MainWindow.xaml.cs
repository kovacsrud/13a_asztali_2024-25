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

namespace WpfIdojarasDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Adapter adapter;
        public MainWindow()
        {
            InitializeComponent();
            adapter=new Adapter("Data Source=idojarasadatok_v2.db;Version=3");
            datagridIdojaras.ItemsSource = adapter.GetData().DefaultView;

        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            adapter.Update();
            datagridIdojaras.Items.Refresh();
        }

        private void datagridIdojaras_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            e.Row.Background = Brushes.Aqua;
        }
    }
}
