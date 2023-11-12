using Microsoft.AspNetCore.Http.HttpResults;

namespace ConsultaCarros
{
    public class ParallelumRepository
    {
        readonly string url = "https://parallelum.com.br/fipe/api/v1/"; //configuração global
        static readonly HttpClient _client = new();

        public async Task<List<ParallelumDto>> ConsultaMarca()
        {
            HttpResponseMessage response = await _client.GetAsync(url + "carros/marcas");

            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ReasonPhrase);

            return await response.Content.ReadFromJsonAsync<List<ParallelumDto>>();
        }

        public async Task<ParallelumModelos> ConsultaModelos(string codigoMarca)
        {
            HttpResponseMessage response = await _client.GetAsync(url + $"carros/marcas/{codigoMarca}/modelos");

            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ReasonPhrase);

            return await response.Content.ReadFromJsonAsync<ParallelumModelos>();
        }
    }
}
