using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterManipulacio
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "Valami szöveg";
            char[] szovegChar = szoveg.ToCharArray();

            for (int i = 0; i < szovegChar.Length; i++)
            {
                if (szovegChar[i]=='a')
                {
                    szovegChar[i] = 'b';
                }
               
            }

            szoveg = new string(szovegChar);
            Console.WriteLine(szoveg);

            //A foreach-ben nem lehet módosítani az adatokat!
            //foreach (var i in szoveg)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();
        }
    }
}
