using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiHybridMeroora.interfaces
{
    public class TableData
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
    }
}
