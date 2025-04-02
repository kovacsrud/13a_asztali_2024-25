using System.Diagnostics;

namespace Rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopper = new Stopwatch();

            stopper.Start();
            Kiir(1);
            stopper.Stop();
            Console.WriteLine($"Végrehajtás ideje:{stopper.ElapsedMilliseconds}");

            //stopper.Reset();
            //stopper.Start();
            //KiirFor();
            //stopper.Stop();
            //Console.WriteLine($"Végrehajtás ideje:{stopper.ElapsedMilliseconds}");
        }

        static void Kiir(int szamlalo)
        {
            Console.WriteLine($"Számláló:{szamlalo}");
            szamlalo++;
            if (szamlalo < 10000)
            {
                Kiir(szamlalo);
            }
        }

        static void KiirFor()
        {
            for (int i = 1; i < 10000; i++)
            {
                Console.WriteLine($"Számláló(for):{i}");
            }
        }
    }
}
