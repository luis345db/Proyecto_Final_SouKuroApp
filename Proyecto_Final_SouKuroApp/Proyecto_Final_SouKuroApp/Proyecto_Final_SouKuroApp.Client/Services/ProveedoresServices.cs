using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class ProveedoresServices
    {
        private readonly HttpClient _httpClient;

        public ProveedoresServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Proveedores>> GetProveedores()
        {
            return await _httpClient.GetFromJsonAsync<List<Proveedores>>("api/Proveedores");
        }

        public async Task<Proveedores> GetProveedores(int id)
        {
            var proveedores = await _httpClient.GetFromJsonAsync<Proveedores>($"api/Proveedores/{id}");
            return proveedores;
        }
        public async Task<HttpResponseMessage> Save(Proveedores proveedores)
        {
            return await _httpClient.PostAsJsonAsync("api/Proveedores", proveedores);
        }
        public async Task<HttpResponseMessage> Update(Proveedores proveedores)
        {
            return await _httpClient.PutAsJsonAsync($"api/Proveedores", proveedores);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Proveedores/{id}");
        }
    }
}
