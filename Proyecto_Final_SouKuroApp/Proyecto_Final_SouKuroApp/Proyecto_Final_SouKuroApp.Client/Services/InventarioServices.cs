using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class InventarioServices
    {
        private readonly HttpClient _httpClient;

        public InventarioServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Inventario>> GetInventario()
        {
            return await _httpClient.GetFromJsonAsync<List<Inventario>>("api/Inventario");
        }

        public async Task<Inventario> GetInventario(int id)
        {
            var inventario = await _httpClient.GetFromJsonAsync<Inventario>($"api/Inventario/{id}");
            return inventario;
        }
        public async Task<HttpResponseMessage> Save(Inventario inventario)
        {
            return await _httpClient.PostAsJsonAsync("api/Inventario", inventario);
        }
        public async Task<HttpResponseMessage> Update(Inventario inventario)
        {
            return await _httpClient.PutAsJsonAsync($"api/Inventario", inventario);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Inventario/{id}");
        }
    }
}
