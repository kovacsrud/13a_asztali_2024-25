using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class JobbAuto
    {
        

        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }

        private int gyartasiev;
        public int GyartasiEv { 
            get { return gyartasiev; } 
            set
            {
                if(value>=1980 && value <= 2022)
                {
                    gyartasiev = value;
                } else
                {
                    throw new ArgumentException("Az értéknek 1980 és 2022 között kell lennie!");
                }
            } 
        }

        public JobbAuto(string rendszam, string marka, string tipus, int gyartasiEv)
        {
            Rendszam = rendszam;
            Marka = marka;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
        }

        public JobbAuto()
        {

        }


    }
}
