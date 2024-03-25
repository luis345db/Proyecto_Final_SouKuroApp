using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class ProductoServices
    {
        private readonly HttpClient _httpClient;

        public ProductoServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Producto>> GetProducto()
        {
            return await _httpClient.GetFromJsonAsync<List<Producto>>("api/Producto");
        }

        public async Task<Producto> GetProducto(int id)
        {
            var producto = await _httpClient.GetFromJsonAsync<Producto>($"api/Producto/{id}");
            return producto;
        }
        public async Task<HttpResponseMessage> Save(Producto producto)
        {
            return await _httpClient.PostAsJsonAsync("api/Producto", producto);
        }
        public async Task<HttpResponseMessage> Update(Producto producto)
        {
            return await _httpClient.PutAsJsonAsync($"api/Producto", producto);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Producto/{id}");
        }
    }
}
