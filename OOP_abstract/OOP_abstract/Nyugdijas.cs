using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_abstract
{
    public class Nyugdijas : Ember
    {
        public string FoglalkozasaVolt { get; set; }
        public override void Alszik()
        {
            Console.WriteLine("A nyugdíjas keveset alszik.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas keveset eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A nyugdíjas keveset iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog.");
        }
    }
}
