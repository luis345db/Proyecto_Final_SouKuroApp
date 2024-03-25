using Shared.Models;
using System.Net.Http.Json;

namespace Proyecto_Final_SouKuroApp.Client.Services
{
    public class EmpleadoServices
    {
        private readonly HttpClient _httpClient;

        public EmpleadoServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Empleado>> GetEmpleado()
        {
            return await _httpClient.GetFromJsonAsync<List<Empleado>>("api/Empleado");
        }

        public async Task<Empleado> GetEmpleado(int id)
        {
            var empleado = await _httpClient.GetFromJsonAsync<Empleado>($"api/Empleado/{id}");
            return empleado;
        }
        public async Task<HttpResponseMessage> Save(Empleado Empleado)
        {
            return await _httpClient.PostAsJsonAsync("api/Empleado", Empleado);
        }
        public async Task<HttpResponseMessage> Update(Empleado Empleado)
        {
            return await _httpClient.PutAsJsonAsync($"api/Empleado", Empleado);
        }
        public async Task<HttpResponseMessage> Delete(int id)
        {
            return await _httpClient.DeleteAsync($"api/Empleado/{id}");
        }
    }
}
