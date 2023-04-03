using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using MauiApp1.Models;

namespace MauiApp1.Repositories
{
    internal class ClientesRepository
    {

        string _dbPath;

        private SQLiteConnection conn;

        private void Init()
        {
            if (conn is not null)
                return;


            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Clientes>();

        }


    }
}
