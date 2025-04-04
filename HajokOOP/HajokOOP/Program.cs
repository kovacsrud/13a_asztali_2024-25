using HajokOOP.Model;

namespace HajokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hajo> hajok=new List<Hajo>();

            hajok.Add(new Teher("Sánta Mária", 145, 15000, 18, 2001, 8000));
            hajok.Add(new Yacht("Csillag",80,6000,32,2020,12,false));

            foreach (var i in hajok)
            {
                if (i.GetType() == typeof(Teher))
                {
                    Teher teher = (Teher)i;
                    Console.WriteLine(teher.Teherkapacitas);
                }
            }
        }
    }
}
