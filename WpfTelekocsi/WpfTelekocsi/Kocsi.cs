using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTelekocsi
{
    public class Kocsi
    {
        public string Indulas { get; set; }
        public string Cel { get; set; }
        public string Rendszam { get; set; }
        public string Telefonszam { get; set; }
        public int Ferohely { get; set; }

        public Kocsi(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);

            Indulas = adatok[0];
            Cel = adatok[1];
            Rendszam = adatok[2];
            Telefonszam = adatok[3];
            Ferohely = Convert.ToInt32(adatok[4]);
        }
    }
}
