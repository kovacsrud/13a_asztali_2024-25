using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAirports.model
{
    public class AirportList
    {
        public List<Airport> Airports { get; set; } = new List<Airport>();

        public AirportList(string fajl,char hatarolo,int start=1)
        {
              var sorok=File.ReadAllLines(fajl,Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Airports.Add(new Airport(sorok[i],hatarolo));
            }
        }
    }
}
