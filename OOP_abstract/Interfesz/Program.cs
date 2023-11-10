namespace Interfesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISikidom> sikidomok=new List<ISikidom>();

            sikidomok.Add(new Kor { Sugar=3});
            sikidomok.Add(new Kor { Sugar = 12 });
            sikidomok.Add(new Kor { Sugar = 31 });
            sikidomok.Add(new Kor { Sugar = 99 });

            sikidomok.Add(new Teglalap { A = 10, B = 22 });
            sikidomok.Add(new Teglalap { A = 33, B = 31 });
            sikidomok.Add(new Teglalap { A = 19, B = 26 });
            sikidomok.Add(new Teglalap { A = 101, B = 59 });


            Console.WriteLine($"Elemek száma:{ sikidomok.Count}");

            var osszkerulet = sikidomok.Sum(x => x.Kerulet());
            var osszterulet=sikidomok.Sum(x => x.Terulet());

            Console.WriteLine($"Összes kerülete:{osszkerulet:0.00},Összes területe:{osszterulet:0.00}");

            foreach (var i in sikidomok)
            {
                Console.WriteLine($"Kerület:{i.Kerulet():0.00},Terület:{i.Terulet():0.00}");
            }

            //Csak a körök összkerülete
            var korOsszkerulet=sikidomok.FindAll(x=>x.GetType() == typeof(Kor)).Sum(x=>x.Kerulet());

            var korOsszTerulet = sikidomok.FindAll(x => x.GetType() == typeof(Kor)).Sum(x => x.Terulet());

            Console.WriteLine($"Körök összkerülete:{korOsszkerulet}, körök összterülete:{korOsszTerulet}");


            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Kor))
                {
                    Kor kor= (Kor)i;
                    Console.WriteLine($"Sugár:{kor.Sugar}");
                }
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap teglalap = (Teglalap)i;
                    Console.WriteLine($"A:{teglalap.A},B:{teglalap.B}");
                }
            }



            Console.ReadKey();
        }
    }
}