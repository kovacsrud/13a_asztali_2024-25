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

            //Karakter felülírása
            Console.WriteLine(szoveg.Replace('a', 'x'));
            //Több karakter felülírása
            Console.WriteLine(szoveg.Replace("al","la"));
            Console.WriteLine(szoveg.Replace(" ", ""));

            //Trim
            string trimm = "-@   _      Szöveg    @@_- '     ";

            Console.WriteLine(trimm);
            char[] levagni = { ' ', '-','_','@','\'' };

            Console.WriteLine(trimm.Trim(levagni));
            Console.WriteLine(trimm.TrimStart(levagni));
            Console.WriteLine(trimm.TrimEnd(levagni));

            string datum = "2022.12.30";

            string ev = datum.Substring(0, 4);
            string honap = datum.Substring(5, 2);
            string nap = datum.Substring(8,2);

            //Konvertálás egész számra
            int evErtek = Convert.ToInt32(ev);
            
            Console.WriteLine($"Ev:{ev},Honap:{honap},Nap:{nap}");

            //String darabolása adott karakter mentén
            string[] datumAdatok = datum.Split('.');

            Console.WriteLine(datumAdatok[0]);

            //var esetében a típust a fordító határozza meg
            
            var datumAdatok2 = "datum";
            



            Console.ReadKey();
        }
    }
}
