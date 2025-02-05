using System.Security.Cryptography;

using System.Text;

namespace Titkositas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Titkosítás");

            string jelszo = "Titok_12";
            string titkositando = "Szigorúan titkos tartalom";
                        
            byte[] titkositandoBin = Encoding.UTF8.GetBytes(titkositando);

            Aes aes=Aes.Create();
            SHA256 sha256 = SHA256.Create();
            byte[] jelszoBin = sha256.ComputeHash(Encoding.UTF8.GetBytes(jelszo));
                       
            

            aes.Key = jelszoBin;
            
            aes.GenerateIV();

            ICryptoTransform titkosito = aes.CreateEncryptor(jelszoBin, aes.IV);
            byte[] titkositott = titkosito.TransformFinalBlock(titkositandoBin, 0, titkositandoBin.Length);

            string kodoltSzoveg = Encoding.UTF8.GetString(titkositott);

            Console.WriteLine(kodoltSzoveg);
            Console.WriteLine(aes.KeySize);
            Console.WriteLine(jelszoBin.Length*8);
            Console.WriteLine(aes.IV.Length*8);
            Console.WriteLine(Encoding.UTF8.GetString(aes.IV));


            //Dekódolni a kódolt szöveget
            ICryptoTransform dekodolo = aes.CreateDecryptor(jelszoBin,aes.IV);
            byte[] dekodoltBin = dekodolo.TransformFinalBlock(titkositott,0,titkositott.Length);

            string dekodoltSzoveg = Encoding.UTF8.GetString(dekodoltBin);

            Console.WriteLine(dekodoltSzoveg);



            //Formátum a kódolt szöveg tárolásához
            //iv hossza/inicializációs vektor/fájlnév hossza/eredeti fájlnév/tartalom hash hossza/tartalom hash/tartalom hossza/tartalom

        }
    }
}
