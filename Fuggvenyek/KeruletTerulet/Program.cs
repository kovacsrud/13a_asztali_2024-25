using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeruletTerulet
{
    class Program
    {
        static double Kerulet(int sugar)
        {
            return 2 * sugar * Math.PI;
        }

        static double Terulet(int sugar)
        {
            return Math.Pow(sugar, 2)*Math.PI;
        }

        static void Main(string[] args)
        {
            //Kör kerületének, területének megadása
            Console.Write("Adja meg a kör sugarát:");
            var sugar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A kör kerülete:{Kerulet(sugar):0.00}");
            Console.WriteLine($"A kör területe:{Terulet(sugar):0.00}");



            Console.ReadKey();
        }
    }
}
