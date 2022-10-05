using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        //void - nem ad vissza értéket
        static void Kiir(string s1,string s2,string s3)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }

        static int Szoroz(int szam1,int szam2)
        {
            return szam1 * szam2;
        }
        static void Main(string[] args)
        {
            Kiir("Valami","Bármi","Akármi");
            Kiir("egy", "kettő", "három");
            Console.WriteLine(Szoroz(10,10));
            int eredmeny = 20 + 5 + Szoroz(10, 20);
            Console.WriteLine(eredmeny);

            Console.ReadKey();
        }
    }
}
