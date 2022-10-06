using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomblista
{
    class Program
    {
        static void Tomblistazas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] szamok = { 12, 34, 56, 221, 556, 23, 889, 122, 67, 98 };
            int[] szamok2 = { 23, 56, 78, 12, 345, 677 };



            //Listázzuk ki az elemeket

            ListTomb(szamok);

            Tomblistazas(szamok);
            Tomblistazas(szamok2);

            Console.ReadKey();
        }

        private static void ListTomb(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
        }
    }
}
