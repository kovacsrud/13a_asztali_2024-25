using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
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

            int[] tippek = new int[hanySzam];
            int[] nyeroSzamok = new int[hanySzam];

            //Tippek bekérése
            //A számnak 1 és osssSzam között kell lennie
            //Egy tipp csak egyszer szerepelhet a tömbben

            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Rossz! {i + 1}.tipp újra:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }
            Console.Write("Tippek:");
            Array.Sort(tippek);
            Tomblista(tippek);

            //Sorsolás
            for (int i = 0; i < hanySzam; i++)
            {
                int temp = rand.Next(1, osszSzam + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }

            //for (int i = 0; i < tippek.Length; i++)
            //{
            //    for (int j = 0; j < nyeroSzamok.Length; j++)
            //    {
            //        if (tippek[i]==nyeroSzamok[j])
            //        {
            //            talalat++;
            //        }
            //    }

            //}

            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }


            Console.Write("Nyerőszámok:");
            Array.Sort(nyeroSzamok);
            Tomblista(nyeroSzamok);

            Console.WriteLine($"Találatok:{talalat}");

            //Találatok meghatározása

            Console.ReadKey();
        }

        private static void Tomblista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
        }
    }
}
