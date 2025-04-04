using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajokOOP.Model
{
    public abstract class Hajo
    {
        public string Nev { get; set; }
        public int Hossz { get; set; }
        public int Suly { get; set; }
        public double MaxSebesseg { get; set; }
        public int EpitesEve { get; set; }


        protected Hajo(string nev, int hossz, int suly, double maxSebesseg, int epitesEve)
        {
            Nev = nev;
            Hossz = hossz;
            Suly = suly;
            MaxSebesseg = maxSebesseg;
            EpitesEve = epitesEve;
        }


        public abstract void Halad();

        public double IdoKalkulacio(int tavolsag)
        {
            return tavolsag / MaxSebesseg;
        }

        public override string ToString()
        {
            return $"Név:{Nev},Hossz:{Hossz},Súly:{Suly},Max.sebesség:{MaxSebesseg},Építés éve:{EpitesEve}";
        }
    }
}
