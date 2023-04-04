using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MauiApp1.Models;
using MauiApp1.Models.Mapping;

namespace MauiApp1.Services
{
    internal interface IRestService
    {
        public Task<List<Mapping>> GetAllClientes();
        public Task<Mapping> GetClienteById(int id);
        public Task<Mapping> AddCliente(Clientes cliente);
        public Task<Mapping> UpdateCliente(int id, Clientes cliente);
        public Task<bool> DeleteCliente(int id);

    }
}
