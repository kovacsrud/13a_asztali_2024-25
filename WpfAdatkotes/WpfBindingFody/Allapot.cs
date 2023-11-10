using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace WpfBindingFody
{
    [AddINotifyPropertyChangedInterface]
    public class Allapot
    {
        public int Ertek { get; set; }
        public int MasikErtek { get; set; }
    }
}
