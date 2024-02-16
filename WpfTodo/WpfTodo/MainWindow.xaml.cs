using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
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
using WpfTodo.Models;

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TodoContext todoContext;
        public ObservableCollection<Todo> Todos { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            todoContext = new TodoContext();
            //todoContext.Add(new Todo {
            //    Title = "Teszt",
            //    Description="Teszt todo leírása",
            //    Completed = false
                
            //});
            //todoContext.SaveChanges();
            todoContext.Todos.Load();
            Todos = todoContext.Todos.Local.ToObservableCollection();

            DataContext = Todos;

        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result=todoContext.SaveChanges();
                if (result>0)
                {
                    datagridTodos.Items.Refresh();
                    MessageBox.Show("Változások mentve!");
                } else
                {
                    MessageBox.Show("Nem történt mentés!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}