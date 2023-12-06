using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

namespace WpfRandomUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users users;
        Posts posts;
        public MainWindow()
        {
            InitializeComponent();
            comboboxUserNumber.Items.Add(5);
            comboboxUserNumber.Items.Add(10);
            comboboxUserNumber.Items.Add(20);
            comboboxUserNumber.Items.Add(30);
            comboboxUserNumber.Items.Add(50);
            comboboxUserNumber.SelectedIndex = 0;

            //string postsStr ="{postlist:"+new WebClient().DownloadString($"https://jsonplaceholder.typicode.com/posts")+"}";

            //JObject postsObj=JObject.Parse(postStr);
            //Posts posts=postsObj.ToObject<Posts>();
         


        }

        public Users GetUsers(int db)
        {
            JObject userJson = JObject.Parse(new WebClient().DownloadString($"https://randomuser.me/api/?results={db}"));

            Users result=userJson.ToObject<Users>();

            return result;
        }

        private void buttonLetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                users = GetUsers((int)comboboxUserNumber.SelectedItem);
                datagridUsers.DataContext = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
