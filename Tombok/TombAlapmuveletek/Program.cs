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
            Console.WriteLine($"Az elemek összege:{osszeg},Átlag:{(double)osszeg/szamok.Length}");

            int min = szamok[0];
            int max = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"Min:{min},Max:{max}");

            Console.WriteLine($"Össz:{szamok.Sum()},Átlag:{szamok.Average()},Min:{szamok.Min()},Max:{szamok.Max()}");

            Console.ReadKey();
        }
    }
}
