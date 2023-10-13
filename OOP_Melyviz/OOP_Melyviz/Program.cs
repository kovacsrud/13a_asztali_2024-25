namespace OOP_Melyviz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Allat allat = new Allat();

            //Allat allat = new Allat {
            //    Faj="kutya",
            //    Kategoria="emlős",
            //    Magassag=45,
            //    Suly=56
            //};

            Allat allat2 = new Allat("Kutya", 45, "emlős", 65);

            Kigyo kigyo = new Kigyo("kígyó", 10, "hüllő", 80, 6, false, "python");



          

            allat2.Eszik();
            allat2.Iszik();
            allat2.Mozog();

            Console.WriteLine($"Az állat súlya:{allat2.Suly}");

            //Kutya kutya = new Kutya
            //{
            //    Faj="kutya",
            //    Fajta="újfundlandi",
            //    Hosszuszoru=true,
            //    Kategoria="emlős",
            //    Magassag=85,
            //    Suly=59
            //};

            Kutya kutya = new Kutya("Kutya",67,"Emlős",56,"dobermann",false);

            kutya.Iszik();
            kutya.Ugat();
            kutya.Mozog();
            kutya.Eszik();
            Console.WriteLine(kutya.Fajta);
            Console.WriteLine(kutya.ToString());

            Console.ReadKey();
        }
    }
}