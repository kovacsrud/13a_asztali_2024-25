using System;
using System.Collections.Generic;

namespace WpfKutyakSqlite.mvvm.models;

public partial class Kutya
{
    public long Id { get; set; }

    public long Fajtaid { get; set; }

    public long Nevid { get; set; }

    public long Eletkor { get; set; }

    public DateTime Utolsoell { get; set; }  

    public virtual Kutyafajtak Fajta { get; set; }  

    public virtual Kutyanevek Nev { get; set; } 
}
