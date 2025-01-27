using System.Text;

namespace BinFajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájlkezelés binárisan");

            var szovegFajl = File.ReadAllBytes("szinek.txt");

            //foreach (var bajt in szovegFajl)
            //{
            //    //Console.Write(bajt+" ");
            //    Console.Write(Convert.ToString(bajt,2).PadLeft(8,'0')+" ");
            //}

            //Console.WriteLine(Encoding.UTF8.GetString(szovegFajl));

            var zipFajl = File.ReadAllBytes("MonthyHallGame.zip");

            //foreach (var bajt in zipFajl)
            //{
            //    Console.Write(Convert.ToString(bajt,2).PadLeft(8,'0')+" ");
            //}
            //Console.WriteLine(Encoding.UTF8.GetString(zipFajl));

            using (MemoryStream ms=new MemoryStream(zipFajl))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    var signature = br.ReadBytes(4);
                    Console.WriteLine($"Signature:{BitConverter.ToString(signature)}");
                    //Console.WriteLine($"Signature:{BitConverter.ToInt32(signature)}");
                    var version = br.ReadBytes(2);
                    //Console.WriteLine($"Version:{BitConverter.ToString(version)}");
                    Console.WriteLine($"Version:{BitConverter.ToInt16(version)}");
                    var flags= br.ReadBytes(2);
                    Console.WriteLine($"Flags:{BitConverter.ToString(flags)}");
                    var compression= br.ReadBytes(2);
                    Console.WriteLine($"Compression:{BitConverter.ToString(compression)}");
                    //00-04 seconds, 05-10 minute, 11-15 hour
                    var modtime = br.ReadBytes(2);
                   

                    Console.WriteLine($"Modtime:{BitConverter.ToString(modtime)}");
                    var moddate = br.ReadBytes(2);
                    Console.WriteLine($"Moddate:{BitConverter.ToString(moddate)}");
                    var crc = br.ReadBytes(4);
                    Console.WriteLine($"Crc:{BitConverter.ToString(crc)}");
                    var compressed = br.ReadBytes(4);
                    Console.WriteLine($"Compressed:{BitConverter.ToString(compressed)}");
                    var uncompressed = br.ReadBytes(4);
                    Console.WriteLine($"Uncompressed:{BitConverter.ToString(uncompressed)}");
                    var filenameLength = br.ReadBytes(2);
                    Console.WriteLine($"File name length:{BitConverter.ToInt16(filenameLength)}");
                    var extraLength = br.ReadBytes(2);
                    Console.WriteLine($"Extra field length:{BitConverter.ToString(extraLength)}");
                    var filename = br.ReadBytes(BitConverter.ToInt16(filenameLength));
                    Console.WriteLine($"Fajlnev:{Encoding.UTF8.GetString(filename)}");


                }
            }


            Console.ReadKey();
        }
    }
}
