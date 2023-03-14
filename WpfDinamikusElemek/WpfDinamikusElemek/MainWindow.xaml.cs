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

namespace WpfDinamikusElemek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                Button button = new Button();
                button.Content = i + 1;
                button.FontSize = 24;
                button.Width = 60;
                
                button.Margin = new Thickness(5);
                button.Click += GombClick;
                wrapGombok.Children.Add(button);
                
            }

        }

        public void GombClick(object sender,RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            //gomb.Background = Brushes.Red;
            //Így is lehet a sendert kezelni
            //Button gomb2 = sender as Button;
            textblockSzam.Text = gomb.Content.ToString();
            wrapGombok.Children.Remove(gomb);
        }
    }
}
