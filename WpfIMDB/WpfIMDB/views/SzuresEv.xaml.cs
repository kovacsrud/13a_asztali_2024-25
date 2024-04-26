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
    /// Interaction logic for SzuresEv.xaml
    /// </summary>
    public partial class SzuresEv : Window
    {
        List<Movie> results=new List<Movie>();
        public SzuresEv(MovieList movieList)
        {
            InitializeComponent();
            DataContext = movieList;
            
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var movielist = DataContext as MovieList;

            datagridMovies.ItemsSource = null;

            results = movielist.Movies.FindAll(x=>x.ReleaseYear==Convert.ToInt32(textboxEv.Text));

            if (results.Count > 0)
            {
                datagridMovies.ItemsSource = results;
            } else
            {
                MessageBox.Show("Nincs a feltételnek megfelelő film!");
            }

            
        }

        private void buttonVissza_Click(object sender, RoutedEventArgs e)
        {
            var movielist=DataContext as MovieList;
            datagridMovies.ItemsSource = movielist.Movies;
        }
    }
}
