using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiHybridMeroora
{
    public static class DbConfig
    {
        private const string dbname = "meroorak.db";
        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

        public static string DatabasePath { 
            get {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbname);
            }
        }
    }
}
