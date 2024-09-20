using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDbKutyak.Model
{
    public class Rendeles
    {
        public int Id { get; set; }
        public int FajtaId { get; set; }
        public int NevId { get; set; }
        public string Nev { get; set; }
        public string Fajta { get; set; }
        public int Eletkor { get; set; }
        public string UtolsoEll { get; set; }
    }
}
