
using CatsService.Services.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsService.Services
{
    public class CatApi
    {
        public async Task<List<CatModel>> GetCaracteristicasAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.thecatapi.com/v1/breeds"),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                //Resposta sem tratamento de erros
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    List<CatModel> resultados = JsonConvert.DeserializeObject<List<CatModel>>(body);
                    return resultados;
                }
                else
                    return null;
            }
        }

        public async Task<CatImages> GetImagemCatById(string reference_image_id)
        {
            string image = reference_image_id.ToString();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.thecatapi.com/v1/images/" + image),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultados = JsonConvert.DeserializeObject<CatImages>(body);
                    return resultados;
                }
                else
                    return null;
            }
        }

        public async void IncludesFavoriteCat(string imageId, string subId)
        {
            var dataJson = new { image_id = imageId, sub_id = subId };
            var json = JsonConvert.SerializeObject(dataJson);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://api.thecatapi.com/v1/favourites"),
                Headers =    {
                 { "x-api-key", "live_GqgbEkgSvEhAJnQVFnwUT1uI9EV39U2MBOaMy7qI9GBjyvE2XXjzOubBis7QdXzq" },
                },
                Content = new StringContent(json, Encoding.UTF8, "application/json")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Item adicionado ao Favoritos. " + body, "Favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async Task<List<CatFavorites>> GetListFavoritos()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.thecatapi.com/v1/favourites"),
                Headers =    {
                 { "x-api-key", "live_GqgbEkgSvEhAJnQVFnwUT1uI9EV39U2MBOaMy7qI9GBjyvE2XXjzOubBis7QdXzq" },
                }

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultados = JsonConvert.DeserializeObject<List<CatFavorites>>(body);
                    return resultados;
                }
                else
                    return null;

            }
        }

        public async void DeleteCatFavoritoById(string idCat)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"https://api.thecatapi.com/v1/favourites/{idCat}"),
                Headers =
            {
                { "x-api-key", "live_GqgbEkgSvEhAJnQVFnwUT1uI9EV39U2MBOaMy7qI9GBjyvE2XXjzOubBis7QdXzq" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var body = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Ocorreu erro na deleção. Status de retorno:" + response.StatusCode);
                }
            }
        }
    }
}
