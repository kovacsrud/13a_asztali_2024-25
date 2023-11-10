using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    public class Kor : ISikidom
    {
        public double Sugar { get; set; }

        public double Kerulet()
        {
            return 2* Sugar*Math.PI;
        }

        public double Terulet()
        {
            //return Sugar*Sugar*Math.PI;
            return Math.Pow(Sugar,2)*Math.PI;
        }
    }
}
