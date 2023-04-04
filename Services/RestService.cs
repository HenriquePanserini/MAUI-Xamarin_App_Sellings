using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

using MauiApp1.Models;
using MauiApp1.Models.Mapping;
using MauiApp1.Repositories;

namespace MauiApp1.Services
{
    internal class RestService : IRestService
    {
       
        HttpClient _httpClient;
        JsonSerializerOptions _serializerOptions;
        ClientesRepository _clienteRepository;

        private List<Mapping> mapping { get; set; }

        public RestService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<List<Mapping>> GetAllClientes()
        {

            mapping = new List<Mapping>();

            Uri uri = new Uri(string.Format(Constants.URL_KEY, string.Empty));

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    mapping = JsonSerializer.Deserialize<List<Mapping>>(content, _serializerOptions);

                }

            }catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }



            return mapping;
        }

        public Task<Mapping> GetClienteById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Mapping> AddCliente(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mapping> UpdateCliente(int id, Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
