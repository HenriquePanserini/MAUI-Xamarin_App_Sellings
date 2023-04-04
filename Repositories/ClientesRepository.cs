using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using MauiApp1.Models;
using MauiApp1.Repositories;
using MauiApp1.Models.Mapping;
using System.Reflection.Metadata;
using MauiApp1.Services;
using System.Collections.ObjectModel;

namespace MauiApp1.Repositories
{
    internal class ClientesRepository
    {

        private SQLiteAsyncConnection Database;
        
        RestService _service;
        Mapping _mapping;

        async Task Init()
        {

            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            Database.CreateTableAsync<Clientes>();

        }

        public async Task<int> InsertClientData(Mapping mapping)
        {
            await Init();

            _service = new RestService();

            return await Database.InsertAsync(mapping);
        } 


    }
}
