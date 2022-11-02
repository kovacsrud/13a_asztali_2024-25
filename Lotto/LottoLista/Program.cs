using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszSzam = 0;
            int hanySzam = 0;
            int talalat = 0;
            Random rand = new Random();

            Console.Write("Hány számot húzunk?:");
            hanySzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból sorsolunk?:");
            osszSzam = Convert.ToInt32(Console.ReadLine());

            List<int> tippek = new List<int>();
            List<int> sorsoloGomb = new List<int>();
            List<int> nyeroSzamok = new List<int>();

            GombInit(osszSzam, sorsoloGomb);

            //ElemLista(sorsoloGomb);

            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Rossz! {i + 1}.tipp újra:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek.Add(temp);
            }
            Console.Write("Tippek:");
            ElemLista(tippek);

            int hetek = 0;
            //Itt indul a ciklus
            while (talalat!=5)
            {

                talalat = 0;   

            //Sorsolás - választunk a sorsoloGomb listából véletlenszerűen és a kiválasztott
            //értéket áttesszük a nyerőszámok közé

            for (int i = 0; i < hanySzam; i++)
            {
                //választás a listából véletlenszerűen
                int index = rand.Next(0, sorsoloGomb.Count);
                nyeroSzamok.Add(sorsoloGomb[index]);
                sorsoloGomb.RemoveAt(index);
                
            }

            
            //Console.Write("Nyerőszámok:");
            //ElemLista(nyeroSzamok);


            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }

                //Vissza kell tenni a nyeroszamokat a "sorsoló gömbbe"
                sorsoloGomb.AddRange(nyeroSzamok);
                nyeroSzamok.Clear();

            Console.WriteLine($"Találatok:{talalat}");
            
            hetek++;

         }

            Console.WriteLine($"Hetek száma:{hetek}, évben:{hetek/52}");
            Console.ReadKey();
        }

        private static void GombInit(int osszSzam, List<int> sorsoloGomb)
        {
            for (int i = 0; i < osszSzam; i++)
            {
                sorsoloGomb.Add(i + 1);
            }
        }

        private static void ElemLista(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
