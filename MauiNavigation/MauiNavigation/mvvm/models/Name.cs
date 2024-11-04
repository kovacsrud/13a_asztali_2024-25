using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace MauiNavigation.mvvm.models
{
    [AddINotifyPropertyChangedInterface]
    public class Name
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
    }
}
