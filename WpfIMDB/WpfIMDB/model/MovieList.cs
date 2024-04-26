using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIMDB.model
{
    public class MovieList
    {
        //Ezt a listát kötjük majd be a gridbe
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<string> Kategoriak { get; set; }= new List<string>();

        public MovieList(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Movies.Add(new Movie(sorok[i], hatarolo));
            }

            //Kategóriák létrehozása
            var katlookup = Movies.ToLookup(x => x.Genre);

            Dictionary<string,string> kategoriak = new Dictionary<string,string>();

            foreach (var i in katlookup)
            {
                
                var daraboltKategoriak = i.Key.ToLower().Split(',');

                for (int j = 0; j < daraboltKategoriak.Length; j++)
                {

                    if (!kategoriak.ContainsKey(daraboltKategoriak[j].Trim()))
                    {
                        kategoriak[daraboltKategoriak[j].Trim()] = daraboltKategoriak[j].Trim();
                    }
                }

                
            }

            foreach (KeyValuePair<string,string> dictData  in kategoriak)
            {
                Kategoriak.Add(dictData.Value);
            }




        }

    }
}
