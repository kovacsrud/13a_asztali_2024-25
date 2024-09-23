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

namespace WpfDbKutyak.Views
{
    /// <summary>
    /// Interaction logic for EditRendeles.xaml
    /// </summary>
    public partial class EditRendeles : Window
    {
        public EditRendeles()
        {
            InitializeComponent();
            comboKutyanevek.ItemsSource = DbRepo.GetKutyanevek();
            comboKutyanevek.SelectedIndex = 0;
            comboKutyafajtak.ItemsSource = DbRepo.GetKutyafajtak();
            comboKutyafajtak.SelectedIndex = 0;
        }
    }
}
