using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesztAlapmuveletek;

namespace Alapmuvelet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesztAlapmuveletek.Alapmuvelet alapmuvelet=new TesztAlapmuveletek.Alapmuvelet();

            Console.WriteLine(alapmuvelet.Osszead(20,20));
            Console.WriteLine(alapmuvelet.Kivon(20,10));
            Console.WriteLine(alapmuvelet.Szoroz(20,20));
            Console.WriteLine(alapmuvelet.Oszt(20,10));

            Console.ReadKey();
        }
    }
}
