using System;
using System.Collections.Generic;

namespace WpfKutyakSqlite.mvvm.models;

public partial class Kutyafajtak
{
    public long Id { get; set; }

    public string Nev { get; set; }  

    public string Eredetinev { get; set; } 

    public virtual ICollection<Kutya> Kutyak { get; set; } = new List<Kutya>();
}
