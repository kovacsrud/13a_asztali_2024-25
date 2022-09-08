using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            //Változók
            int a = 102;
            Console.WriteLine(a);
            a = 12668;
            Console.WriteLine(a);
            int b = a + 2000;
            uint elojelNelkul = 234;
            short rovid = 234;
            long nagySzam = 34249238749234923;

            byte nyolcBit = 123;

            Console.WriteLine(b);

            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);

            Console.WriteLine(UInt32.MinValue);
            Console.WriteLine(UInt32.MaxValue);

            Console.WriteLine(UInt64.MaxValue);
            Console.WriteLine(Int64.MaxValue);

            //Nem egész számokat tároló változók (lebegőpontos)
            float nemEgesz1 = 12.123456789012345678901234567890f;
            double nemEgesz2 = 12.123456789012345678901234567890;
            decimal nemEgesz3 = 12.123456789012345678901234567890m;

            Console.WriteLine($"Float:{nemEgesz1}");
            Console.WriteLine($"Double:{nemEgesz2}");
            Console.WriteLine($"Decimal:{nemEgesz3}");

            //Szöveg
            string szoveg = "Valami szöveg";
            Console.WriteLine(szoveg.Length);
            Console.WriteLine(szoveg[szoveg.Length-1]);
            Console.WriteLine(szoveg.First());
            Console.WriteLine(szoveg.Last());

            //A string típusú változó nem változtatható meg.

            szoveg = "Másik szöveg";
            Console.WriteLine(szoveg);

            //Karakter típus: egyetlen karakter
            char karakter = 'x';

            Console.WriteLine(karakter);

            //logikai típus
            bool logikai = true;

            logikai = false;
            //vagy
            logikai = !logikai;

            Console.WriteLine(logikai);






            Console.ReadKey();

        }
    }
}
