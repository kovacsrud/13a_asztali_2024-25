using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] szamok2d = new int[15, 20];
            Random rand = new Random();

            for (int i = 0; i < szamok2d.GetLength(0); i++)
            {
                for (int j = 0; j < szamok2d.GetLength(1); j++)
                {
                    szamok2d[i, j] = rand.Next(10, 100);
                }

            }

            for (int i = 0; i < szamok2d.GetLength(0); i++)
            {
                for (int j = 0; j < szamok2d.GetLength(1); j++)
                {
                    Console.Write(szamok2d[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(szamok2d.Length);

            Console.ReadKey();
        }
    }
}
