using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciklus - ismételt tevékenységek
            //Írjunk ki egy bekért szöveget 100x
            Console.Write("Adj meg egy szöveget:");
            string szoveg = Console.ReadLine();

            //Előírt lépésszámú
            for (int i = 0; i < 100; i++)
            {
                //ciklusmag
                Console.WriteLine($"{i+1}.{szoveg}");
            }

            //Elöltesztelő
            int cv = 0;
            while (cv<100)
            {
                Console.WriteLine($"{cv+1}.{szoveg}");
                cv++;
            }

            //Hátultesztelő - egyszer mindenféleképpen lefut
            cv = 0;
            do
            {
                Console.WriteLine($"{cv + 1}.{szoveg}");
                cv++;
            } while (cv<100);



            Console.ReadKey();
        }
    }
}
