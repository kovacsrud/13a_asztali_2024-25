using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listák kezelése
            List<int> szamok = new List<int>();
            szamok.Add(12);
            szamok.Add(129);
            szamok.Add(415);

            List<int> szamok2 = new List<int>();
            szamok2.Add(386);
            szamok2.Add(511);

            //Elemek száma (listánál count)
            Console.WriteLine($"Elemek száma:{szamok.Count}");

            //Az elemek a tömbhöz hasonlóan elérhetőek az indexük segítségével
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.WriteLine("------------------------");
            //a lista bejárható foreach ciklussal is
            //a lista foreach ciklusban nem módosítható!

            szamok.AddRange(szamok2);

            //Törlés érték szerint
            //szamok.Remove(511);

            //Törlés index szerint
            //szamok.RemoveAt(0);

            //Adott feltétel(ek)nek megfelelő elemek törlése
            //szamok.RemoveAll(x=>x>200);

            //Adott darabszámú elem eltávolítása a megadott indextől
            //szamok.RemoveRange(1, 2);

            //Lista elemeinek eltávolítása
            //szamok.Clear();

            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }

            //Vizsgálatok
            if (szamok.Contains(387))
            {
                Console.WriteLine("Benne van");
            } else
            {
                Console.WriteLine("Nincs benne");
            }

            if (szamok.Any(x=>x>400))
            {
                Console.WriteLine("Vannak 400-nál nagyobb elemek");
            } else
            {
                Console.WriteLine("Nincsenek 400-nál nagyobb elemek");
            }
           

            Console.ReadKey();
        }
    }
}
