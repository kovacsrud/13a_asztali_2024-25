using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fájlok beolvasása
            try
            {
                FileStream fajl = new FileStream("felfedezesek.csv", FileMode.Open);
                StreamReader reader = new StreamReader(fajl, Encoding.Default);
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    //Itt dolgozzuk fel valamilyen módon a sor adatait
                    var sor = reader.ReadLine().Split(';');
                    Console.WriteLine($"Év:{sor[0]},Elem:{sor[1]},Vegyjel:{sor[2]},Rendszám:{sor[3]},Felfedező:{sor[4]}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
