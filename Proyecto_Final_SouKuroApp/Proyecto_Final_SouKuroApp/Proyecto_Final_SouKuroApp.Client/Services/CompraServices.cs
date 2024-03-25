using Shared.Models;
using System.Net.Http.Json;
namespace Proyecto_Final_SouKuroApp.Client.Services;
public class CompraServices
{
    private readonly HttpClient _httpClient;

    public CompraServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<Compra>> GetCompra()
    {
        return await _httpClient.GetFromJsonAsync<List<Compra>>("api/Compra");
    }

    public async Task<Compra> GetCompra(int id)
    {
        var compra = await _httpClient.GetFromJsonAsync<Compra>($"api/Compra/{id}");
        return compra;
    }
    public async Task<HttpResponseMessage> Save(Compra Compra)
    {
        return await _httpClient.PostAsJsonAsync("api/Compra", Compra);
    }
    public async Task<HttpResponseMessage> Update(Compra Compra)
    {
        return await _httpClient.PutAsJsonAsync($"api/Compra", Compra);
    }
    public async Task<HttpResponseMessage> Delete(int id)
    {
        return await _httpClient.DeleteAsync($"api/Compra/{id}");
    }
}

