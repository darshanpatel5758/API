using API.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API
{
    public class FinalSpaceClient
    {
        private readonly HttpClient _client;

        public  FinalSpaceClient(HttpClient client) 
        {
            _client = client;
        }

        public async Task<IEnumerable<People>> Peoples()
        {
            return await GetAsync<IEnumerable<People>>("/swapi.dev/api/people/");
        }

        public async Task<IEnumerable<Planet>> Planets()
        {
            return await GetAsync<IEnumerable<Planet>>("/swapi.dev/api/planets/");
        }


        private async Task<T> GetAsync<T>(string endPoint)
        {
            var response = await _client.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();

                var model = await JsonSerializer.DeserializeAsync<T>(content);

                return model;
            }
            else
            {
                throw new HttpRequestException("Final Space API returned bad response");
            }
        }
    }

}
