using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Repositories
{
    internal static class Constants
    {
        public static string URL_KEY = "http://192.168.0.101:3000/cliente";

        public static string DatabaseFilename = "dados.db3";

        public static SQLite.SQLiteOpenFlags Flags =
            //open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exists
            SQLite.SQLiteOpenFlags.Create | 
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);


    }
}
