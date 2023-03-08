using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfNotepad
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

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Nevjegy_Click(object sender, RoutedEventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.Show();
        }

        private void Megnyit_Click(object sender,RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|adatfájl (*.csv)|*.csv|weblap (*.html)|*.html|minden fájl|*.*";

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    var szoveg = File.ReadAllText(dialog.FileName, Encoding.Default);
                    textboxSzoveg.Text = szoveg;
                    this.Title = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void MentesMaskent_Click(object sender,RoutedEventArgs e)
        {
            MentesMaskent();
        }

        private void MentesMaskent()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|adatfájl (*.csv)|*.csv|weblap (*.html)|*.html|minden fájl|*.*";

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, textboxSzoveg.Text, Encoding.Default);
                    this.Title = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }

        }
    }
}
