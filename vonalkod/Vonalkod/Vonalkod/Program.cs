using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vonalkod
{
    class Program
    {
        static int EllenorzoSzam(string vonalkod)
        {
            int ellenorzoSzam = 0;
            int osszeg = 0;

            for (int i = 0; i < vonalkod.Length-1; i++)
            {
                if (i%2!=0)
                {
                    osszeg += (int)Char.GetNumericValue(vonalkod[i]);
                }
                if (i % 2 == 0)
                {
                    osszeg += (int)Char.GetNumericValue(vonalkod[i]) * 3;
                }                               
            }
            ellenorzoSzam = 10 - (osszeg % 10);

            return ellenorzoSzam;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(EllenorzoSzam("5997001771532"));
            Console.WriteLine(EllenorzoSzam("5997001770313"));
            Console.WriteLine(EllenorzoSzam("5991234567894"));

            Console.ReadKey();
        }
    }
}
