using System;
using System.Collections.Generic;

namespace WpfKutyakSqlite.mvvm.models;

public partial class Kutyanevek
{
    public long Id { get; set; }

    public string Kutyanev { get; set; } 

    public virtual ICollection<Kutya> Kutyak { get; set; } = new List<Kutya>();
}
