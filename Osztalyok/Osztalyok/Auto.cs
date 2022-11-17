using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Auto
    {
       private string rendszam;
       private string marka;
       private string tipus;
       private int gyartasiev;

        //Konstruktor, az osztály példányosításakor automatikusan lefut
        public Auto(string rendszam,string marka,string tipus,int gyartasiev)
        {
            this.rendszam = rendszam;
            this.marka = marka;
            this.tipus = tipus;
            this.gyartasiev = gyartasiev;
        }

        public void setRendszam(string rendszam)
        {
            this.rendszam = rendszam;
        }

        public string getRendszam()
        {
            return rendszam;
        }
    }
}
