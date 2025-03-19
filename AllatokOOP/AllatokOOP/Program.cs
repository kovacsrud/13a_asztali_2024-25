namespace AllatokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Allat> allatok = new List<Allat>();

            allatok.Add(new Madar("A","papagáj",3,20));
            allatok.Add(new Madar("B", "veréb", 1, 10));
            allatok.Add(new Emlos("C", "macska", 3, true));
            allatok.Add(new Emlos("D", "delfin", 6, false));
            allatok.Add(new Hullo("E", "vipera", 4, true));
            allatok.Add(new Hullo("F", "gyík", 1, false));

            foreach (var i in allatok)
            {
                Console.WriteLine(i.ToString());
                if (i.GetType() == typeof(Madar))
                {
                    
                    Madar madar = (Madar)i;
                    Console.WriteLine($"Szárnyfesztáv:{madar.SzarnyFesztav}");
                }
            }

        }
    }
}
