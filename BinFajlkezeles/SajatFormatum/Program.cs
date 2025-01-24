using System.Text;

namespace SajatFormatum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fajlnev = "szinek.txt";
            var szovegfajl = File.ReadAllBytes(fajlnev);
            var fajlnevBin = Encoding.UTF8.GetBytes(fajlnev);

            //Fájlformátum:fájlnév/adatok
            //fájl mérete byteokban:
            Console.WriteLine(szovegfajl.Length);
            Console.WriteLine(fajlnevBin.Length);

            var fajlnevHosszBin = BitConverter.GetBytes(fajlnevBin.Length);
            var fajlhosszBin=BitConverter.GetBytes(szovegfajl.Length);

            //saját fájlformátum: filenév hossza 4/filenév változó/fájl hossza 4/fájl adatok változó

            var binData = new byte[fajlnevHosszBin.Length+fajlnevHosszBin.Length+fajlnevBin.Length+szovegfajl.Length];

            Console.WriteLine(binData.Length);

            using (MemoryStream ms=new MemoryStream(binData))
            {
                using (BinaryWriter bw=new BinaryWriter(ms))
                {
                    bw.Write(fajlnevHosszBin);
                    bw.Write(fajlnevBin);
                    bw.Write(fajlhosszBin);
                    bw.Write(szovegfajl);
                }
                File.WriteAllBytes("szinek.bin",ms.ToArray());
                Console.WriteLine("Adatok fájlba írva!");
            }

            //Nyerjük vissza a bin fájlból a szövegfájlt és írjuk ki egy másik nevű szöveges fájlként!

            var binVissza = File.ReadAllBytes("szinek.bin");

            using (MemoryStream ms=new MemoryStream(binVissza))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    var filenevHosszBin=br.ReadBytes(4);
                    var filenevHossz = BitConverter.ToInt32(filenevHosszBin);
                    Console.WriteLine(filenevHossz);
                    br.ReadBytes(filenevHossz);
                    var filehosszBin = br.ReadBytes(4);
                    var filehossz = BitConverter.ToInt32(filehosszBin);
                    Console.WriteLine(filehossz);
                    var fileAdatok = br.ReadBytes(filehossz);

                    File.WriteAllBytes("szinek_masolat.txt", fileAdatok);
                    
                }

            }


            Console.ReadKey();
        }
    }
}
