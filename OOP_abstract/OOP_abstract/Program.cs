namespace OOP_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sportolo sportolo = new Sportolo {
                VezetekNev="Kis",
                KeresztNev="Ubul",
                SportAg="kézilabda",
                Suly=85,
                SzuletesiEv=2007
            };

            sportolo.Alszik();
            sportolo.Eszik();
            Console.WriteLine(sportolo.Eletkor());

            Nyugdijas nyugdijas = new Nyugdijas
            {
                FoglalkozasaVolt="gépész",
                VezetekNev="Kósa",
                KeresztNev="Márk",
                Suly=89,
                SzuletesiEv=1951

            };

            Console.WriteLine(nyugdijas.Eletkor());
            nyugdijas.Eszik();
            nyugdijas.Mozog();

            Console.ReadKey();
        }
    }
}