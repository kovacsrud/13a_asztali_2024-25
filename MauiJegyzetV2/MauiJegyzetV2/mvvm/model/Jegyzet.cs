using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiJegyzetV2.interfaces;
using SQLite;

namespace MauiJegyzetV2.mvvm.model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("jegyzetek")]
    public class Jegyzet:TableData
    {
        //[PrimaryKey,AutoIncrement]
        //public int Id { get; set; }
        [NotNull]
        public string Cim { get; set; }
        [NotNull]
        public string Szoveg { get; set; }
        [NotNull]
        public DateTime Datum { get; set; } = DateTime.Now;

    }
}
