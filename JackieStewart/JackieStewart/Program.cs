using System.Text;

namespace JackieStewart
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<RaceYear> raceYears = new List<RaceYear>();

            try
            {
                var sorok = File.ReadAllLines("jackie.txt", Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    raceYears.Add(new RaceYear(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"3.feladat:{raceYears.Count}");

            var maxStart = raceYears.Max(x=>x.Races);

            var maxRaceYear = raceYears.Find(x => x.Races == maxStart);
            
            Console.WriteLine($"4.feladat:{maxRaceYear?.Year}");

            var stat = raceYears.ToLookup(x=>x.Year.ToString().Substring(0,3));

            foreach (var i in stat)
            {
                if (i.Key=="196")
                {
                    Console.WriteLine($"60-as évek:{i.Sum(x=>x.Wins)}");
                } else
                {
                    Console.WriteLine($"70-es évek:{i.Sum(x => x.Wins)}");
                }
            }

            try
            {
                FileStream file = new FileStream("jackie.html", FileMode.Create);

                using (StreamWriter writer=new StreamWriter(file,Encoding.UTF8))
                {
                    writer.WriteLine("<!doctype html>");
                    writer.WriteLine("<html>");
                    writer.WriteLine("<head></head>");
                    writer.WriteLine("<style>td{border:1px solid black}</style>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("<h1>Jackie Stewart</h1>");
                    writer.WriteLine("<table>");
                    
                    foreach (var i in raceYears) {
                        writer.WriteLine($"<tr><td>{i.Year}</td><td>            {i.Races}</td><td>{i.Wins}</td></tr>");
                    }
                    writer.WriteLine("</table>");
                    writer.WriteLine("</body");
                    writer.WriteLine("</html");
                }

                Console.WriteLine("Írás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}