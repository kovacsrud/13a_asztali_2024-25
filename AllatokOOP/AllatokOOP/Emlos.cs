using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Emlos:Allat
    {
        public Emlos(string nev, string faj, int kor,bool isszoros) : base(nev, faj, kor)
        {
            IsSzoros = isszoros;
        }

        public bool IsSzoros { get; set; }

        public override void Hang()
        {
            Console.WriteLine("Az emlős morgást hallat.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Ez az emlős:{(IsSzoros ? "szőrös":"nem szőrös")}";
        }
    }
}
