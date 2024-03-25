using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class InformeServices
    {
        private readonly HttpClient _httpClient;

        public InformeServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Informe>> GetInforme()
        {
            return await _httpClient.GetFromJsonAsync<List<Informe>>("api/Informe");
        }

        public async Task<Informe> GetInforme(int id)
        {
            var informe = await _httpClient.GetFromJsonAsync<Informe>($"api/Informe/{id}");
            return informe;
        }
        public async Task<HttpResponseMessage> Save(Informe Informe)
        {
            return await _httpClient.PostAsJsonAsync("api/Informe", Informe);
        }
        public async Task<HttpResponseMessage> Update(Informe informe)
        {
            return await _httpClient.PutAsJsonAsync($"api/Informe", informe);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Informe/{id}");
        }
    }
}
