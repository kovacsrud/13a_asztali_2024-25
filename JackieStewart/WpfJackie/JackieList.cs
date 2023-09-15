using JackieStewart;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfJackie
{
    public class JackieList
    {
        public List<RaceYear> RaceYears { get; set; }

        public JackieList(string fajl,int start=1)
        {
            RaceYears = new List<RaceYear>();

            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                RaceYears.Add(new RaceYear(sorok[i]));
            }
        }
    }
}
