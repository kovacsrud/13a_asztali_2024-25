using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatkotesDatagrid
{
    public class Felfedezes
    {
        public string Ev { get; set; }
        public string Elem { get; set; }
        public string Vegyjel { get; set; }
        public int Rendszam { get; set; }
        public String Felfedezo { get; set; }

        public Felfedezes(string sor,char hatarolo)
        {
            var soradatok = sor.Split(hatarolo);
            Ev = soradatok[0];
            Elem = soradatok[1];
            Vegyjel = soradatok[2];
            Rendszam = Convert.ToInt32(soradatok[3]);
            Felfedezo = soradatok[4];
        }
    }
}
