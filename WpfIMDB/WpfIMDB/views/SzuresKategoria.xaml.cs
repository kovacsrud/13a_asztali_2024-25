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
using WpfIMDB.model;

namespace WpfIMDB.views
{
    /// <summary>
    /// Interaction logic for SzuresKategoria.xaml
    /// </summary>
    public partial class SzuresKategoria : Window
    {
        public SzuresKategoria(MovieList movieList)
        {
            InitializeComponent();
            DataContext = movieList;
            //Az XAML-ben is beállítható!
            //comboboxKategoria.SelectedIndex = 0;
        }

        private void comboboxKategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottKat = comboboxKategoria.SelectedItem.ToString();

            var movies=DataContext as MovieList;

            var results=movies.Movies.FindAll(x=>x.Genre.ToLower().Contains(kivalasztottKat));

            datagridMovies.ItemsSource= results;
        }
    }
}
