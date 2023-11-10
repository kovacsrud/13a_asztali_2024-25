using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_abstract
{
    //Absztrakt osztály, csak öröklési célokat szolgál
    public abstract class Ember
    {
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public int Suly { get; set; }
        public int SzuletesiEv { get; set; }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }

        public abstract void Eszik();
        public abstract void Iszik();
        public abstract void Alszik();
        public abstract void Mozog();

    }
}
