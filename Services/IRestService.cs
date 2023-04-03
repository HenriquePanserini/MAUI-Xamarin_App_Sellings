using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MauiApp1.Models;

namespace MauiApp1.Services
{
    internal interface IRestService
    {
        public Task<List<Clientes>> GetAllClientes();
        public Task<Clientes> GetClienteById(int id);
        public Task<Clientes> AddCliente(Clientes cliente);
        public Task<Clientes> UpdateCliente(int id, Clientes cliente);
        public Task<bool> DeleteCliente(int id);

    }
}
