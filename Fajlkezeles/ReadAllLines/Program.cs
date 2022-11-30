using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elem> elemek = new List<Elem>();
            try
            {
                var sorok = File.ReadAllLines("felfedezesek.csv", Encoding.Default);
                
                for (int i = 1; i < sorok.Length; i++)
                {
                    //feldaraboljuk az aktuális sort
                    var adatok = sorok[i].Split(';');
                    //példányosítunk egyet az Elem osztályból, ez
                    //a példány kerül majd a listába
                    Elem elem = new Elem
                    {
                        Ev = adatok[0],
                        ElemNev = adatok[1],
                        Vegyjel = adatok[2],
                        Rendszam = Convert.ToInt32(adatok[3]),
                        Felfedezo = adatok[4]
                    };
                    //a példányosított elemet a listához adjuk
                    elemek.Add(elem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.WriteLine($"Az elemek darabszáma:{elemek.Count}");

            var okoriak = elemek.FindAll(x => x.Ev == "Ókor");

            foreach (var i in okoriak)
            {
                Console.WriteLine($"{i.Ev},{i.ElemNev},{i.Vegyjel},{i.Rendszam},{i.Felfedezo}");
            }

            var abetusek = elemek.FindAll(x => x.Vegyjel.StartsWith("A"));

            foreach (var i in abetusek)
            {
                Console.WriteLine($"{i.Ev},{i.ElemNev},{i.Vegyjel},{i.Rendszam},{i.Felfedezo}");
            }


            Console.ReadKey();
        }
    }
}
