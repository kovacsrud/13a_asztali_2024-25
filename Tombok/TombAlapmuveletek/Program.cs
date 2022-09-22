using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombAlapmuveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[100];
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(1, 100 + 1);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"{szamok[i]} ");
            }

            //Mennyi a tömb elemeinek összege?
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg = osszeg + szamok[i];
                //osszeg+=szamok[i]

            }

            Console.WriteLine();
            Console.WriteLine($"Az elemek összege:{osszeg},Átlag:{osszeg/szamok.Length}");

            Console.ReadKey();
        }
    }
}
