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
using WpfDbKutyak.Model;
using System.Data.SQLite;

namespace WpfDbKutyak.Views
{
    /// <summary>
    /// Interaction logic for ViewKutyanev.xaml
    /// </summary>
    public partial class ViewKutyanev : Window
    {
        //private string connectionString = "Data Source=kutyak.db";
        public ViewKutyanev()
        {
            InitializeComponent();
            datagridKutyanevek.ItemsSource = GetKutyanevek();
        }

        private List<Kutyanev> GetKutyanevek()
        {
            List<Kutyanev> kutyanevek = new List<Kutyanev>();

            try
            {
                //kapcsolat->sql parancs->végrehajtás
                using (SQLiteConnection connection=new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyanevek";

                    using (SQLiteCommand command=new SQLiteCommand(sqlCommand,connection))
                    {
                                                
                        using (SQLiteDataReader reader=command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kutyanev kutyanev = new Kutyanev();
                                kutyanev.Id = Convert.ToInt32(reader["Id"]);
                                kutyanev.KutyaNev = reader["kutyanev"].ToString();
                                kutyanevek.Add(kutyanev);
                            }
                        }

                    }

                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }




            return kutyanevek;
        }
    }
}
