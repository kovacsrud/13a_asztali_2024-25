using KRHash;

namespace HashTeszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHash createHash = new CreateHash();

            string md5hash = createHash.MakeHash(HashType.MD5, "Valami, bármi, akármi");
            string sha1hash = createHash.MakeHash(HashType., "Valami,bármi,akármi", true);

            Console.WriteLine(md5hash);
            Console.WriteLine(sha1hash);
        }
    }
}
