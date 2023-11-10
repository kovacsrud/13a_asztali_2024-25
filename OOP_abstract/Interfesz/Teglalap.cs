using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    public class Teglalap : ISikidom
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Kerulet()
        {
            return 2 * (A + B);
        }

        public double Terulet()
        {
            return A * B;
        }
    }
}
