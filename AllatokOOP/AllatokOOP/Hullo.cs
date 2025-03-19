using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Hullo:Allat
    {
        public bool IsMerges { get; set; }

        public Hullo(string nev, string faj, int kor,bool ismerges) : base(nev, faj, kor)
        {
            IsMerges = ismerges;
        }       

        public override void Hang()
        {
            Console.WriteLine("A hüllő sziszeg.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Ez a hüllő {(IsMerges ? "mérges":"nem mérges")}";
        }
    }
}
