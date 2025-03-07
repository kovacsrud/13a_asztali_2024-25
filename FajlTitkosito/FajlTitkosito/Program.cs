using System.Text;

namespace FajlTitkosito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájl titkosítás/visszafejtés");
            //Titkosito.Titkositas("proba.txt", "titkos.bin", "Titok_12");

            //Console.WriteLine(Titkosito.Message);

            Titkosito.Visszafejtes("titkos.bin","Titok_12");

            Console.WriteLine(Titkosito.Message);
        }
    }
}
