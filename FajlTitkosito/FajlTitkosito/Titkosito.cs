using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FajlTitkosito
{
    public static class Titkosito
    {
        public static string Message { get; set; }

        public static void Titkositas(string fajlnev,string kodoltFajlnev,string jelszo)
        {
            try
            {
                byte[] fajl=File.ReadAllBytes(fajlnev);
                int fajlLength=fajl.Length;
                Aes aes = Aes.Create();
                SHA256 sha256 = SHA256.Create();
                byte[] kulcs=sha256.ComputeHash(Encoding.UTF8.GetBytes(jelszo));
                aes.GenerateIV();
                byte[] tartalomHash = sha256.ComputeHash(fajl);
                byte[] binFajlnev = Encoding.UTF8.GetBytes(fajlnev);
                int binFajlnevLength=binFajlnev.Length;

                ICryptoTransform encoder= aes.CreateEncryptor(kulcs,aes.IV);
                byte[] encoded = encoder.TransformFinalBlock(fajl,0,fajl.Length);
                int encodedLength=encoded.Length;

                byte[] encodedFile = new byte[aes.IV.Length+binFajlnevLength+binFajlnev.Length+tartalomHash.Length+encodedLength+encoded.Length];

                using (MemoryStream ms=new MemoryStream(encodedFile))
                {
                    using (BinaryWriter writer=new BinaryWriter(ms))
                    {
                        writer.Write(aes.IV);
                        writer.Write(binFajlnevLength);
                        writer.Write(binFajlnev);
                        writer.Write(tartalomHash);
                        writer.Write(encodedLength);
                        writer.Write(encoded);
                    }
                    File.WriteAllBytes(kodoltFajlnev,encodedFile);
                    Message = $"{kodoltFajlnev} kiírva!";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;                
            }
        }

        public static void Visszafejtes(string fajlnev,string jelszo)
        {
            try
            {
                byte[] fajl=File.ReadAllBytes(fajlnev);
                Aes aes = Aes.Create();
                SHA256 sha256 = SHA256.Create();
                byte[] kulcs=sha256.ComputeHash(Encoding.UTF8.GetBytes(jelszo));
                byte[] initVektor;
                byte[] visszaFajlnev;
                byte[] visszaTartalomHash;
                byte[] visszaTartalom;

                using (MemoryStream ms=new MemoryStream(fajl))
                {
                    using (BinaryReader reader=new BinaryReader(ms))
                    {
                        initVektor = reader.ReadBytes(16);
                        int fajlnevMeret = BitConverter.ToInt32(reader.ReadBytes(4));
                        visszaFajlnev=reader.ReadBytes(fajlnevMeret);
                        visszaTartalomHash=reader.ReadBytes(32);
                        int tartalomHossz=BitConverter.ToInt32(reader.ReadBytes(4));
                        visszaTartalom=reader.ReadBytes(tartalomHossz);
                    }
                }

                ICryptoTransform dekodolo = aes.CreateDecryptor(kulcs, initVektor);
                byte[] dekodolt = dekodolo.TransformFinalBlock(visszaTartalom, 0, visszaTartalom.Length);

                byte[] ellenorzoHash=sha256.ComputeHash(dekodolt);

                if (Encoding.UTF8.GetString(ellenorzoHash)==Encoding.UTF8.GetString(visszaTartalomHash))
                {
                    Message = "A jelszó megfelelő!";
                    File.WriteAllBytes(Encoding.UTF8.GetString(visszaFajlnev),dekodolt);
                } else
                {
                    Message = "A jelszó nem megfelelő!";
                }

            }
            catch (CryptographicException)
            {
                Message = "A jelszó nem megfelelő!";
            }
            catch (Exception ex)
            {
                Message = ex.Message;                
            }
        }
    }
}
