using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Melyviz
{
    public class Kutya:Allat
    {
        public Kutya(string faj, int magassag, string kategoria, int suly,string fajta,bool hosszuszoru) : base(faj, magassag, kategoria, suly)
        {
            Faj=faj;
            Magassag=magassag;
            Kategoria=kategoria;
            Suly=suly;
            Fajta=fajta;
            Hosszuszoru=hosszuszoru;
        }

        public string Fajta { get; set; }
        public bool Hosszuszoru { get; set; }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A kutya iszik");
        }
        public override void Mozog()
        {
            Console.WriteLine("A kutya gyorsan mozog");
        }

        public override string ToString()
        {
            return base.ToString()+$",Fajta:{Fajta},Hosszúszőrű:{Hosszuszoru}";
        }
    }
}
