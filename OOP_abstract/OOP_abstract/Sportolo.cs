using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_abstract
{
    public class Sportolo : Ember
    {
        public string SportAg { get; set; }
        public override void Alszik()
        {
            Console.WriteLine("A sportoló sokat alszik.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló kevés alkoholt iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló gyorsan mozog.");
        }
    }
}
