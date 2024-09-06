using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAirports.model
{
    public class Airport
    {
        public int Id { get; set; }
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string AirportCountryCode { get; set; }
        public int AirportElevation { get; set; }
        public string AirportContinent { get; set; }

        public Airport(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Id=Convert.ToInt32(adatok[0]);
            AirportCode = adatok[1];
            AirportName = adatok[2];
            AirportCountryCode = adatok[3];

            if (adatok[4].Length>0)
            {
                AirportElevation = Convert.ToInt32(adatok[4]);
            } else
            {
                AirportElevation = -1;
            }
            
            AirportContinent = adatok[5];
        }
    }
}
