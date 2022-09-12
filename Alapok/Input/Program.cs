using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Felhasználói input
            Console.Write("Adjon meg egy szöveget:");
            var szoveg = Console.ReadLine();

            Console.WriteLine(szoveg);

            Console.Write("Adjon meg egy számot:");
            var szam = Convert.ToInt32(Console.ReadLine());

            char kar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"Karakter:{kar}");

            Console.WriteLine(szam);

            Console.ReadKey();
        }
    }
}
