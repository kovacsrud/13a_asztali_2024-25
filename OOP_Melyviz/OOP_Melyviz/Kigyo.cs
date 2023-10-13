using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Melyviz
{
    public class Kigyo:Allat
    {
        

        public Kigyo(string faj, int magassag, string kategoria, int suly, int hossz, bool isMerges, string fajta) : base(faj, magassag, kategoria, suly)
        {
            Faj = faj;
            Magassag = magassag;
            Kategoria = kategoria;
            Suly = suly;
            Hossz = hossz;
            IsMerges = isMerges;
            Fajta = fajta;
        }

        public int Hossz { get; set; }
        public bool IsMerges { get; set; }
        public string Fajta { get; set; }

        public override void Mozog()
        {
            Console.WriteLine("A kígyó csúszik");
        }
    }
}
