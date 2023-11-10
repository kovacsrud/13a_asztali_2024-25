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

namespace WpfAdatkotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textboxAllapot_TextChanged(object sender, TextChangedEventArgs e)
        {
            sliderAllapot.Value = Convert.ToDouble(textboxAllapot.Text);
            progressbarAllapot.Value= Convert.ToDouble(textboxAllapot.Text);
        }

        private void sliderAllapot_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textboxAllapot.Text=sliderAllapot.Value.ToString();
            progressbarAllapot.Value=sliderAllapot.Value;
        }
    }
}
