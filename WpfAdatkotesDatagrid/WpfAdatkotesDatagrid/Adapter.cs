using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatkotesDatagrid
{
    public class Adapter
    {
        public ObservableCollection<Felfedezes> Felfedezesek { get; set; }=new ObservableCollection<Felfedezes>();
               

        public Adapter(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.UTF7);
            for (int i = start; i < sorok.Length; i++)
            {
                Felfedezesek.Add(new Felfedezes(sorok[i], hatarolo));
            }
        }
    }
}
