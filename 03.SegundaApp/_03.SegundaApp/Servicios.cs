using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _03.SegundaApp
{
    public class Servicios<TModel> where TModel:class
    {
        HttpClient client;
        const string urlBase = "http://ejemplovideoclub.azurewebsites.net/api/";

        public HttpClient RestService()
        {
            //var authData = string.Format("{0}:{1}", "MCSD", "e41cec0123cf55a884b58d3c40f54ff8aeb3e7eb");
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
            var authHeaderValue = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes("MCSD" + ":" + "e41cec0123cf55a884b58d3c40f54ff8aeb3e7eb"));

            client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

            return client;
        }

        public async Task<List<TModel>> Get(String controlador)
        {
            client = RestService();
            var listado = new List<TModel>();
            var miUrl = new Uri(urlBase + controlador);
            var response = await client.GetAsync(miUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                listado = JsonConvert.DeserializeObject<List<TModel>>(content);
            }
            return listado;
        }
    }
}
