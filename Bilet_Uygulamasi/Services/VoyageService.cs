using Bilet_Uygulamasi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bilet_Uygulamasi.Services
{
    internal interface IVoyageService
    {
        Task<List<Voyage>> GetVoyages();
        Task Add(Voyage voyage);
        Task Delete(int Id);
       
    }

    public class VoyageService : IVoyageService
    {
        HttpClient httpClient;
        JsonSerializerOptions jsonSerializerOptions;

        public VoyageService() {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
           
        }

        public async Task Add(Voyage voyage)
        {
            var json = JsonSerializer.Serialize(voyage);
            JsonContent jsonContent= JsonContent.Create(voyage);
            var response= await httpClient.PostAsync("https://localhost:7281/seferler", jsonContent);
            if(response.IsSuccessStatusCode)
            {

            }
        }

        public async Task Delete(int Id)
        {
            var response = await httpClient.DeleteAsync($"https://localhost:7281/seferler/{Id}");
            if (response.IsSuccessStatusCode)
            {
              
            }
        }


        public async Task<List<Voyage>> GetVoyages()
        {
            var response = await httpClient.GetAsync("https://localhost:7281/seferler");
            if(response.IsSuccessStatusCode)
            {
                string jsonContent =await response.Content.ReadAsStringAsync();
                var sonuc= JsonSerializer.Deserialize<List<Voyage>>(jsonContent, jsonSerializerOptions);
                return sonuc;
            }
            return new List<Voyage>();
        }

       
    }
}
