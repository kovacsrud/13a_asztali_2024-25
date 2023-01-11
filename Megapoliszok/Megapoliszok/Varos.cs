using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapoliszok
{
    class Varos
    {
        public string Orszag { get; set; }
        public string VarosNev { get; set; }
        public int Nepesseg1 { get; set; }
        public int Nepesseg2 { get; set; }

        public Varos(string sor)
        {
            var adatok = sor.Split(';');
            Orszag = adatok[0];
            VarosNev = adatok[1];
            Nepesseg1 = Convert.ToInt32(adatok[2]);
            Nepesseg2 = Convert.ToInt32(adatok[3]);
        }

    }
}
