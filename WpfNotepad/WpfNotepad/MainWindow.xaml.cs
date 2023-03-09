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
        bool modositva = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            if (modositva)
            {
                var valasz = MessageBox.Show("Akarja menteni a módosításokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (valasz==MessageBoxResult.OK)
                {
                    MentesMaskent();
                } else
                {
                    Environment.Exit(0);
                }
                
                
                
            }
            
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

        private void Mentes_Click(object sender,RoutedEventArgs e)
        {
            if (this.Title=="NotePad")
            {
                MentesMaskent();
            } else
            {
                try
                {
                    File.WriteAllText(this.Title, textboxSzoveg.Text,Encoding.Default);
                    modositva = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
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
                    modositva = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }

        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {
            modositva = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (modositva)
            {
                var valasz = MessageBox.Show("Akarja menteni a változásokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (valasz==MessageBoxResult.OK)
                {
                    MentesMaskent();
                }
            }
        }

        private void textboxSzoveg_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                menuitemKivagas.IsEnabled = true;
                menuitemMasolas.IsEnabled = true;
            }
            if (textboxSzoveg.SelectedText.Length<1)
            {
                menuitemKivagas.IsEnabled = false;
                menuitemMasolas.IsEnabled = false;
            }
        }

        private void Masolas_Click(object sender,RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                Clipboard.SetText(textboxSzoveg.SelectedText);
            }

            menuitemBeillesztes.IsEnabled = true;
        }

        private void Kivagas_Click(object sender,RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                Clipboard.SetText(textboxSzoveg.SelectedText);

                textboxSzoveg.Text = textboxSzoveg.Text.Remove(textboxSzoveg.CaretIndex,textboxSzoveg.SelectedText.Length);
                menuitemBeillesztes.IsEnabled = true;

            }
        }

        private void Beilleszt_Click(object sender, RoutedEventArgs e)
        {
            var vagolapSzoveg = Clipboard.GetText();
            textboxSzoveg.Text = textboxSzoveg.Text.Insert(textboxSzoveg.CaretIndex, vagolapSzoveg);
        }
    }
}
