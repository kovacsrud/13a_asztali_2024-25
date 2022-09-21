using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb: több azonos típusú értéket tároló adatszerkezet.
            //Az elemek számát deklaráláskor meg kell adni.

            //öt egész számot tartalmazó tömb
            int[] szamok = new int[5];

            //Console.WriteLine(szamok[0]);

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            int[] masikSzamok = { 12, 45, 59, 112, 67, 334, 99, 677 };

            for (int i = 0; i < masikSzamok.Length; i++)
            {
                if (i<masikSzamok.Length-1)
                {
                    Console.Write($"{masikSzamok[i]},");
                } else
                {
                    Console.Write($"{masikSzamok[i]}");
                }
                
            }

            int[] harmadikSzamok = masikSzamok;

            harmadikSzamok[1] = 233;

            Console.WriteLine($"Masodik:{masikSzamok[1]},Harmadik:{harmadikSzamok[1]}");

            int a = 7;
            int b = a;

            b = 14;

            Console.WriteLine($"A:{a},B:{b}");

            Console.ReadKey();
        }
    }
}
