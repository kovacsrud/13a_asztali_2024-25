using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Melyviz
{
    //Az osztály általában vmilyen valós dolog leképezése
    public class Allat
    {
        //Az osztály adatokat és metódusokat tartalmaz

        //Bezártság elve: az osztály csak azt mutatja a külvilág felé, amit nagyon szükséges, az adatokat csak metódusokon keresztül lehessen elérni.

        private string faj="";

        //Property: beállító függvény + lekérdező függvény + változó
        public string Faj { get; set; } = "";

        private int magassag;
        public int Magassag {
            get { return magassag; }
            set {

                if (value>0 && value<500) {
                    magassag = value;
                } else
                {
                    throw new ArgumentException("Nem megfelelő érték!");
                }
            
            }
        }
        public string Kategoria { get; set; } = "";
        public int Suly { get; set; }

        public Allat(string faj,int magassag,string kategoria,int suly)
        {
            Faj = faj;
            Magassag = magassag;
            Kategoria = kategoria;
            Suly = suly;
        }

        //public Allat()
        //{
            
        //}

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public virtual void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public void SetFaj(string faj)
        {
            if (faj.Length > 1)
            {
                this.faj = faj;
            }
            else {
                throw new ArgumentException("Nem megfelelő az érték!");
            }
            
        }

        public string GetFaj()
        {
            return this.faj;
        }

        public override string ToString()
        {
            return $"Faj:{Faj},Magasság:{Magassag},Kategória:{Kategoria},Súly:{Suly}";
        }

    }
}
