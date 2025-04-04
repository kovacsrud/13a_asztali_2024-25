using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajokOOP.Model
{
    public class Yacht : Hajo
    {
        public int MaxUtasszam { get; set; }
        public bool VanHelikopterLeszallo { get; set; }
        public Yacht(string nev, int hossz, int suly, double maxSebesseg, int epitesEve,int maxutasszam,bool vanhelikopterleszallo) : base(nev, hossz, suly, maxSebesseg, epitesEve)
        {
            MaxUtasszam = maxutasszam;
            VanHelikopterLeszallo= vanhelikopterleszallo;
        }

        public override void Halad()
        {
            Console.WriteLine("A yacht gyorsan siklik a vízen");
        }
    }
}
