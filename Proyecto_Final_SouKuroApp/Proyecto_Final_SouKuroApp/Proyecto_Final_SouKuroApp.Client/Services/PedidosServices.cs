using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class PedidosServices
    {
        private readonly HttpClient _httpClient;

        public PedidosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Pedidos>> GetPedidos()
        {
            return await _httpClient.GetFromJsonAsync<List<Pedidos>>("api/Pedidos");
        }

        public async Task<Pedidos> GetPedidos(int id)
        {
            var pedidos = await _httpClient.GetFromJsonAsync<Pedidos>($"api/Pedidos/{id}");
            return pedidos;
        }
        public async Task<HttpResponseMessage> Save(Pedidos pedidos)
        {
            return await _httpClient.PostAsJsonAsync("api/Pedidos", pedidos);
        }
        public async Task<HttpResponseMessage> Update(Pedidos pedidos)
        {
            return await _httpClient.PutAsJsonAsync($"api/Pedidos", pedidos);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Pedidos/{id}");
        }
    }
}
