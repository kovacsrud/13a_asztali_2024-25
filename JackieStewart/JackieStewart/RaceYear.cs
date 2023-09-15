using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackieStewart
{
    public class RaceYear
    {
        public int Year { get; set; }
        public int Races { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int Fastests { get; set; }

        public RaceYear(string sor)
        {
            var adat = sor.Split('\t');    
            Year = int.Parse(adat[0]);
            Races = int.Parse(adat[1]);
            Wins = int.Parse(adat[2]);
            Podiums = int.Parse(adat[3]);
            Poles = int.Parse(adat[4]);
            Fastests = int.Parse(adat[5]);
        }

    }
}
