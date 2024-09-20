using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfDbKutyak.Model;

namespace WpfDbKutyak
{
    public static class DbRepo
    {
        public static List<Kutyanev> GetKutyanevek()
        {
            List<Kutyanev> kutyanevek = new List<Kutyanev>();

            try
            {
                //kapcsolat->sql parancs->végrehajtás
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = "select * from kutyanevek";

                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                    {

                        using (SQLiteDataReader reader = command.ExecuteReader())
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

        public static void UjKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "insert into kutyanevek (kutyanev) values(@kutyanev)";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@kutyanev", kutyanev.KutyaNev);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok}.sor beszúrva");
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message, "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

        public static void ModositKutyanev(Kutyanev kutyanev)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string insertCommand = "update kutyanevek set kutyanev=@kutyanev where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(insertCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", kutyanev.Id);
                        command.Parameters.AddWithValue("@kutyanev", kutyanev.KutyaNev);
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok}.sor módosítva");
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message, "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

        public static void TorolKutyanev(int id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string deleteCommand = "delete from kutyanevek where Id=@id";

                    using (SQLiteCommand command = new SQLiteCommand(deleteCommand, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        
                        var sorok = command.ExecuteNonQuery();
                        MessageBox.Show($"{sorok}.sor törölve");
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message, "Adatbázis hiba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

        public static List<Rendeles> GetRendelesiAdatok()
        {
            List<Rendeles> rendelesLista = new List<Rendeles>();

            try
            {
                //kapcsolat->sql parancs->végrehajtás
                using (SQLiteConnection connection = new SQLiteConnection(DbTools.connectionString))
                {
                    connection.Open();
                    string sqlCommand = @"select kutya.Id as Id,
                                         fajtaid,
                                         nevid,
                                         eletkor,
                                         utolsoell,
                                         kutyanev,
                                         nev as fajtanev
                    from kutya,kutyanevek,kutyafajtak
                    where kutya.fajtaid=kutyafajtak.Id and kutya.nevid=kutyanevek.Id";

                    using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                    {

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rendeles rendeles = new Rendeles();
                                rendeles.Id = Convert.ToInt32(reader["Id"]);
                                rendeles.NevId = Convert.ToInt32(reader["nevid"]);
                                rendeles.FajtaId = Convert.ToInt32(reader["fajtaid"]);
                                rendeles.Eletkor = Convert.ToInt32(reader["eletkor"]);
                                rendeles.UtolsoEll = reader["utolsoell"].ToString();
                                rendeles.Fajta = reader["fajtanev"].ToString();
                                rendeles.Nev = reader["kutyanev"].ToString();

                                rendelesLista.Add(rendeles);
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




            return rendelesLista;
        }

    }
}
