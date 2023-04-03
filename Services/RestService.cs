using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MauiApp1.Repositories;
using System.Diagnostics;

namespace MauiApp1.Services
{
    internal class RestService : IRestService
    {
       
        HttpClient _httpClient;
        JsonSerializerOptions _serializerOptions;
        Constants url;

        private List<Clientes> clientes { get; set; }

        public RestService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<List<Clientes>> GetAllClientes()
        {
            clientes = new List<Clientes>();
            url = new Constants();

            Uri uri = new Uri(string.Format(url.URL_KEY, string.Empty));
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    clientes = JsonSerializer.Deserialize<List<Clientes>>(content, _serializerOptions);
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return clientes;
        }
        public Task<Clientes> GetClienteById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Clientes> AddCliente(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Clientes> UpdateCliente(int id, Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
