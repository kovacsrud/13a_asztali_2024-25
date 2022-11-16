using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int c = 0;

            try
            {
                c = a / b;
                try
                {
                    throw new FormatException("Hibás változó");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);                   
                }
              
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nullával való osztás!");
            }
          
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }
            finally
            {
                //Mindig lefut az itt lévő kód!
                Console.WriteLine(c);
            }
            

            


            Console.ReadKey();
        }
    }
}
