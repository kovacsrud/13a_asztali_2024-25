using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterManipulacio
{
    class Program
    {
        static int Osszeg(string szoveg)
        {
            int osszeg = 0;
            char[] szovegChar = szoveg.ToCharArray();
            for (int i = 0; i < szovegChar.Length; i++)
            {
                if (Char.IsDigit(szovegChar[i]))
                {
                    osszeg = osszeg + (int)Char.GetNumericValue(szovegChar[i]);
                }
            }
            return osszeg;
        }
        static string Fordit2(string szoveg)
        {
            char[] szovegChar = szoveg.ToCharArray();
            for (int i = 0; i < szovegChar.Length; i++)
            {
                if (i==0 || (Char.IsWhiteSpace(szovegChar[i-1]) && i>0))
                {
                    szovegChar[i] = Char.ToUpper(szovegChar[i]);
                }
                else
                {
                    szovegChar[i] = Char.ToLower(szovegChar[i]);
                }
            }
            return new string(szovegChar);
        }
        static string Fordit(string szoveg)
        {
            char[] szovegChar = szoveg.ToCharArray();
            for (int i = 0; i < szovegChar.Length; i++)
            {
                if (Char.IsLower(szovegChar[i]))
                {
                    szovegChar[i] = Char.ToUpper(szovegChar[i]);
                }
                else
                {
                    szovegChar[i] = Char.ToLower(szovegChar[i]);
                }
            }
            return new string(szovegChar);
        }
        static void Main(string[] args)
        {
            string szoveg = "Valami Szöveg";
                    
            Console.WriteLine(Fordit(szoveg));

            string masikSzoveg = "boldog hétfőt neked!";
            Console.WriteLine(Fordit2(masikSzoveg));

            Console.WriteLine(Osszeg("Valami 999"));

            //A foreach-ben nem lehet módosítani az adatokat!
            //foreach (var i in szoveg)
            //{
            //    Console.WriteLine(i);
            //}
           
            Console.ReadKey();
        }
    }
}
