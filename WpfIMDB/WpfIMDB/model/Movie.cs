using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIMDB.model
{
    public class Movie
    {
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public double ImdbRating { get; set; }
        public double MetaScore { get; set; }
        public int Votes { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Gross { get; set; }

        public Movie(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            MovieName = adatok[0];
            ReleaseYear = Convert.ToInt32(adatok[1]);
            Duration= Convert.ToInt32(adatok[2]);
            ImdbRating= Convert.ToDouble(adatok[3].Replace(".",","));

            if (adatok[4] == "")
            {
                MetaScore = 0;
            } else
            {
                MetaScore = Convert.ToDouble(adatok[4].Replace(".",","));
            }
            Votes = Convert.ToInt32(adatok[5].Replace(",", ""));
            Genre = adatok[6];
            Director = adatok[7];
            Cast = adatok[8];
            Gross = adatok[9];
        }
    }
}
