using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emberek
{
    class Ember
    {
        
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public int SzuletesiEv { get; set; }
        public string LakhelyVaros { get; set; }

        public Ember(string vezeteknev, string keresztnev, int szuletesiEv, string lakhelyVaros)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzuletesiEv = szuletesiEv;
            LakhelyVaros = lakhelyVaros;
        }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }

    }
}
