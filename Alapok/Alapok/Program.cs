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
            float nemEgesz1 = 12.234544f;
            double nemEgesz2 = 12.4534553665;
            decimal nemEgesz3 = 12.53454534554m;





            Console.ReadKey();

        }
    }
}
