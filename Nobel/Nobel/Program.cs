using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NobelDijas> nobeldijasok = new List<NobelDijas>();
            try
            {
                var sorok = File.ReadAllLines("nobel.csv", Encoding.UTF8);

                for (int i = 1; i < sorok.Length; i++)
                {
                    nobeldijasok.Add(new NobelDijas(sorok[i]));
                }

                Console.WriteLine("Beolvasás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatok száma:{nobeldijasok.Count}");

            var macdonald = nobeldijasok.Find(x => x.Vezeteknev.ToLower() == "mcdonald".ToLower() && x.Keresztnev.ToLower() == "Arthur B.".ToLower());

            if (macdonald != null)
            {
                Console.WriteLine(macdonald.Tipus);
            } else
            {
                Console.WriteLine("Nincs ilyen Nobel-díjas!");
            }

            var irodalmi2017 = nobeldijasok.Find(x => x.Tipus == "irodalmi" && x.Ev == 2017);

            if (irodalmi2017!=null)
            {
                Console.WriteLine($"{irodalmi2017.Vezeteknev} {irodalmi2017.Keresztnev}");
            } else
            {
                Console.WriteLine("Nincs ilyen!");
            }

            var szervezetek = nobeldijasok.FindAll(x => x.Ev >= 1990 && x.Tipus == "béke" && x.Vezeteknev=="");

            foreach (var i in szervezetek)
            {
                Console.WriteLine($"{i.Vezeteknev} {i.Keresztnev}");
            }

            var curie = nobeldijasok.FindAll(x=>x.Vezeteknev.Contains("Curie"));
            foreach (var i in curie)
            {
                Console.WriteLine($"{i.Ev},{i.Tipus},{i.Vezeteknev} {i.Keresztnev}");
            }


            Console.ReadKey();
        }
    }
}
