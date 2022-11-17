using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osztalyok;

namespace AutoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JobbAuto> autok = new List<JobbAuto>();

            autok.Add(new JobbAuto("LKL-001", "Skoda", "Octavia", 2001));
            autok.Add(new JobbAuto("KLU-011", "Kia", "Rio", 2006));
            autok.Add(new JobbAuto("EPU-897", "Kia", "Ceed", 2008));
            autok.Add(new JobbAuto("NUM-084", "Renault", "Megane", 2017));
            autok.Add(new JobbAuto("NOK-117", "Opel", "Astra", 2016));

            Console.WriteLine($"Autók száma:{autok.Count}");

            var keresettAutok = autok.FindAll(x => x.GyartasiEv >= 2006 && x.GyartasiEv <= 2010);

            foreach (var i in keresettAutok)
            {
                Console.WriteLine($"{i.GyartasiEv},{i.Rendszam},{i.Marka}");
            }

            var kiaAutok = autok.FindAll(x => x.Marka == "Skoda");

            foreach (var i in kiaAutok)
            {
                Console.WriteLine($"{i.GyartasiEv},{i.Rendszam},{i.Marka}");
            }

            //Van-e Fabia a listában?
            if (autok.Any(x=>x.Tipus=="Fabia"))
            {
                Console.WriteLine("Van Fabia");
            } else
            {
                Console.WriteLine("Nincs Fabia");
            }


            Console.ReadKey();
        }
    }
}
