using System.Diagnostics;

namespace Keresesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            Random random = new Random();
            Stopwatch stopper = new Stopwatch();

            int[] szamok = new int[n];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(0, 1000 + 1);
            }

            int keresett = 219;

            stopper.Start();
            Console.WriteLine($"A keresett szám indexe:{LinearisKereses(keresett,szamok)}");
            stopper.Stop();
            Console.WriteLine($"Lineáris keresés ideje:{stopper.ElapsedTicks}");

            stopper.Reset();
            stopper.Start();
            Console.WriteLine($"A keresett szám indexe(bin):{BinarisKereses(keresett, szamok)}");
            stopper.Stop();

            Console.WriteLine($"Bináris keresés ideje:{stopper.ElapsedTicks}");

        }

        private static int BinarisKereses(int keresett, int[] szamok)
        {
            Array.Sort(szamok);
            int bal = 0;
            int jobb=szamok.Length-1;
            while (bal <= jobb) {
                int kozep = bal + (jobb - bal) / 2;

                if (szamok[kozep]==keresett)
                {
                    return kozep;
                } else if (szamok[kozep]<keresett)
                {
                    bal = kozep + 1;
                } else
                {
                    jobb = kozep - 1;
                }
            }

            return -1;

        }

        private static int LinearisKereses(int keresett, int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]==keresett)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
