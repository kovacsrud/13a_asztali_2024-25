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

namespace WpfAdatkotesDatagrid
{
    /// <summary>
    /// Interaction logic for FelfedezesekWin.xaml
    /// </summary>
    public partial class FelfedezesekWin : Window
    {
        public Adapter Adapter { get; set; } = new Adapter("felfedezesek.csv", ';');
        public FelfedezesekWin()
        {
            InitializeComponent();
            DataContext = Adapter;
        }
    }
}
