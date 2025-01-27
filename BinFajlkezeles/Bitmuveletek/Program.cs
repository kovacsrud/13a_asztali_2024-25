namespace Bitmuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitenkénti műveletek");

            byte a = 14;
            Console.WriteLine($"A:{Convert.ToString(a,2).PadLeft(8,'0')}");

            byte b = 12;
            Console.WriteLine($"B:{Convert.ToString(b, 2).PadLeft(8, '0')}");

            byte c = 9;
            Console.WriteLine($"C:{Convert.ToString(c, 2).PadLeft(8, '0')}");

            byte d = 6;
            Console.WriteLine($"D:{Convert.ToString(d, 2).PadLeft(8, '0')}");

            ushort tomor = 0;
            Console.WriteLine($"Tömör:{Convert.ToString(tomor, 2).PadLeft(16, '0')}");

            //Értékek kiírása 16-bitre

            tomor = (ushort)((a<<12) | (b<<8) | (c<<4) | d);
            
            Console.WriteLine($"Tömör:{Convert.ToString(tomor, 2).PadLeft(16, '0')}");

            //Értékek visszanyerése

            byte visszaA = (byte)((tomor>>12) & 0b_0000_0000_0000_1111);
            Console.WriteLine(visszaA);
            byte visszaB = (byte)((tomor >> 8) & 0b_0000_0000_0000_1111);
            Console.WriteLine(visszaB);
            byte visszaC = (byte)((tomor >> 4) & 0b_0000_0000_0000_1111);
            Console.WriteLine(visszaC);
            byte visszaD = (byte)((tomor) & 0b_0000_0000_0000_1111);
            Console.WriteLine(visszaD);







        }
    }
}
