using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajokOOP.Model
{
    public class Evezos : Hajo
    {
        public int EvezokSzama { get; set; }
        public Evezos(string nev, int hossz, int suly, double maxSebesseg, int epitesEve,int evezokszama) : base(nev, hossz, suly, maxSebesseg, epitesEve)
        {
            EvezokSzama = evezokszama;
        }

        public override void Halad()
        {
            Console.WriteLine("Ezt a hajót evezőkkel hajtják.");
        }
        public override string ToString()
        {
            return base.ToString()+$" Evezők száma:{EvezokSzama}";
        }
    }
}
