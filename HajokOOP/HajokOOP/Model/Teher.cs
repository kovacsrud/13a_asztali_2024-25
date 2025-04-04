using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajokOOP.Model
{
    public class Teher : Hajo
    {
        public int Teherkapacitas { get; set; }
        public Teher(string nev, int hossz, int suly, double maxSebesseg, int epitesEve,int teherkapacitas) : base(nev, hossz, suly, maxSebesseg, epitesEve)
        {
            Teherkapacitas = teherkapacitas;
        }

        public override void Halad()
        {
            Console.WriteLine("A teherhajó motorral, lassan halad.");
        }

        public override string ToString()
        {
            return base.ToString()+$" A hajó {Teherkapacitas} tonna terhet tud szállítani";
        }

    }
}
