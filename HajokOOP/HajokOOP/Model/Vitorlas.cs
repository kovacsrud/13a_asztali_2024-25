using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajokOOP.Model
{
    public class Vitorlas : Hajo
    {
        public  int ArbocSzam { get; set; }

        public Vitorlas(string nev, int hossz, int suly, double maxSebesseg, int epitesEve,int arbocszam) : base(nev, hossz, suly, maxSebesseg, epitesEve)
        {
            ArbocSzam = arbocszam;
        }

        public override void Halad()
        {
            Console.WriteLine("A vitorlás a szél segítségével halad.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Árbocok száma:{ArbocSzam}";
        }
    }
}
