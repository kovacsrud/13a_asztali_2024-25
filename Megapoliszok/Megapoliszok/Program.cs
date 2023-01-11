using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Megapoliszok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Varos> varosok = new List<Varos>();
            try
            {
                var sorok = File.ReadAllLines("megapoliszok.txt", Encoding.UTF8);
                for (int i = 1; i < sorok.Length; i++)
                {
                    varosok.Add(new Varos(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.WriteLine($"Megapoliszok száma:{varosok.Count}");

            var indiai = varosok.FindAll(x => x.Orszag.ToLower() == "india".ToLower()).Count;
            Console.WriteLine($"Indiai városok száma:{indiai} db.");

            var usaAtlag = varosok.FindAll(x => x.Orszag.ToLower() == "egyesült államok".ToLower()).Average(x=>x.Nepesseg2);

            //Console.WriteLine(usaAtlag.Count);

            Console.WriteLine($"Usa városok lakosságának átlaga:{usaAtlag}");

            var kinaiak = varosok.FindAll(x => x.Orszag == "Kína");
            var legnagyobbKinaiVaros = kinaiak.Find(x=>x.Nepesseg1==kinaiak.Max(y=>y.Nepesseg1));

            Console.WriteLine($"Legnagyobb kínai város:{legnagyobbKinaiVaros.VarosNev},{legnagyobbKinaiVaros.Nepesseg1}");

            if (varosok.Any(x=>x.VarosNev=="Budapest"))
            {
                Console.WriteLine("Budapest megtalálható a listán");
            } else
            {
                Console.WriteLine("Budapest nincs a listán");
            }

            var budapest = varosok.Find(x => x.VarosNev == "Budapest");

            if (budapest!=null)
            {
                Console.WriteLine("Budapest megtalálható a listán");
            } else
            {
                Console.WriteLine("Budapest nincs a listán");
            }

            Console.ReadKey();
        }
    }
}
