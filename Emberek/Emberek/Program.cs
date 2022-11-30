using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] veznevek = { "Kis", "Nagy", "Kósa", "Szabó", "Ormai" };
            string[] keresztnevek = { "Ágnes", "Réka", "János", "Zoltán", "Egon" };
            string[] varosok = { "Bélmegyer", "Gyula", "Lenti", "Miskolc", "Sopron" };

            List<Ember> emberek = new List<Ember>();

            //példányosítsunk 100 embert és tegyük a listába!
            for (int i = 0; i < 100; i++)
            {
                var veznev = veznevek[rand.Next(0, veznevek.Length)];
                var kernev = keresztnevek[rand.Next(0, keresztnevek.Length)];
                var varos = varosok[rand.Next(0, varosok.Length)];
                var szulev = rand.Next(1930, 2022 + 1);
                emberek.Add(new Ember(veznev, kernev, szulev, varos));

            }
            foreach (var i in emberek)
            {
                Console.WriteLine($"{i.Vezeteknev} {i.Keresztnev},{i.SzuletesiEv},{i.LakhelyVaros}");
            }
            

            Console.ReadKey();
        }
    }
}
