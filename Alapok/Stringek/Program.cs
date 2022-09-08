using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "ValAmi SzöveG";
            string szoveg2 = "Valami szöveg";

            Console.WriteLine(szoveg.ToUpper());
            Console.WriteLine(szoveg.ToLower());

            if (szoveg.ToLower()==szoveg2.ToLower())
            {
                Console.WriteLine("Egyenlőek");
            } else
            {
                Console.WriteLine("Nem egyenlőek");
            }

            Console.WriteLine(szoveg.Contains("ami"));
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.EndsWith("Val"));

            Console.ReadKey();
        }
    }
}
