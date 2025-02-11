using System.Security.Cryptography;

using System.Text;

namespace Titkositas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titkosítás");

            string fajlnev = "nemtitkos.txt";
            byte[] fajlnevBin=Encoding.UTF8.GetBytes(fajlnev);
            int fajlnevHossz=fajlnevBin.Length; 


            string jelszo = "Titok_12";
            string titkositando = "Szigorúan titkos tartalom";
                        
            byte[] titkositandoBin = Encoding.UTF8.GetBytes(titkositando);

            Aes aes=Aes.Create();
            SHA256 sha256 = SHA256.Create();
            byte[] jelszoBin = sha256.ComputeHash(Encoding.UTF8.GetBytes(jelszo));

            byte[] tartalomHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(titkositando));
                       
            

            aes.Key = jelszoBin;
            
            aes.GenerateIV();

            ICryptoTransform titkosito = aes.CreateEncryptor(jelszoBin, aes.IV);
            byte[] titkositott = titkosito.TransformFinalBlock(titkositandoBin, 0, titkositandoBin.Length);
            int titkositottMeret=titkositott.Length;

            string kodoltSzoveg = Encoding.UTF8.GetString(titkositott);

            //Console.WriteLine(kodoltSzoveg);
            //Console.WriteLine(aes.KeySize);
            //Console.WriteLine(jelszoBin.Length*8);
            //Console.WriteLine(aes.IV.Length*8);
            Console.WriteLine(Encoding.UTF8.GetString(aes.IV));
            Console.WriteLine($"Tartalom hash{Encoding.UTF8.GetString(tartalomHash)}");

            //A titkosított adat fájlba írása
            //Formátum a kódolt szöveg tárolásához
            //iv hossza/inicializációs vektor/fájlnév hossza/eredeti fájlnév/tartalom hash hossza/tartalom hash/tartalom hossza/tartalom

            //Fájl formátum egyszerűsítve:
            //IV 16byte//fájlnév hossza 4byte/eredeti fájlnév változó/tartalom hash -32 byte/tartalom hossza -4byte/tartalom -változó

            //Byte tömb méretének a meghatározása

            var kodoltAdatok = new byte[aes.IV.Length+fajlnevHossz+fajlnevBin.Length+tartalomHash.Length+titkositottMeret+titkositott.Length];

            using (MemoryStream ms=new MemoryStream(kodoltAdatok))
            {
                using (BinaryWriter writer=new BinaryWriter(ms))
                {
                    //IV kiírás
                    writer.Write(aes.IV);
                    writer.Write(fajlnevHossz);
                    writer.Write(fajlnevBin);
                    writer.Write(tartalomHash);
                    writer.Write(titkositottMeret);
                    writer.Write(titkositott);
                }
                File.WriteAllBytes("titkositott.bin", kodoltAdatok);
                Console.WriteLine("Fájl kiírva");
            }


            Console.WriteLine($"IV mérete:{aes.IV.Length} byte");
            Console.WriteLine($"Hash méret:{jelszoBin.Length} byte");

            //Visszaolvasás

            Console.WriteLine("-==========Visszaolvasás===========-");
            byte[] titkositottFajl = File.ReadAllBytes("titkositott.bin");
            byte[] dekodolni;

            using (MemoryStream ms=new MemoryStream(titkositottFajl))
            {
                using (BinaryReader br=new BinaryReader(ms))
                {
                    byte[] IV = br.ReadBytes(16);
                    Console.WriteLine(Encoding.UTF8.GetString(IV));
                    byte[] fajlNevMeret= br.ReadBytes(4);
                    Console.WriteLine(BitConverter.ToInt32(fajlNevMeret));
                    byte[] fajlVisszaNev= br.ReadBytes(BitConverter.ToInt32(fajlNevMeret));
                    Console.WriteLine(Encoding.UTF8.GetString(fajlVisszaNev));
                    byte[] tartalomHashVissza= br.ReadBytes(32);
                    Console.WriteLine(Encoding.UTF8.GetString(tartalomHashVissza));
                    byte[] tartalomVisszaMeret= br.ReadBytes(4);
                    Console.WriteLine(BitConverter.ToInt32(tartalomVisszaMeret));
                    dekodolni= br.ReadBytes(BitConverter.ToInt32(tartalomVisszaMeret));
                    
                }
            }

            Console.WriteLine(dekodolni.Length);

            //Dekódolni a kódolt szöveget
            ICryptoTransform dekodolo = aes.CreateDecryptor(jelszoBin,aes.IV);
            byte[] dekodoltBin = dekodolo.TransformFinalBlock(dekodolni,0,dekodolni.Length);

            string dekodoltSzoveg = Encoding.UTF8.GetString(dekodoltBin);


            byte[] dekodoltHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(dekodoltSzoveg));
            Console.WriteLine($"Dekódolt szöveg hash:{Encoding.UTF8.GetString(dekodoltHash)}");

            if (Encoding.UTF8.GetString(dekodoltHash) == Encoding.UTF8.GetString(tartalomHash))
            {
                Console.WriteLine("Megfelelő jelszó, sikeres dekódolás!");
                Console.WriteLine(dekodoltSzoveg);
            }

            








        }
    }
}
