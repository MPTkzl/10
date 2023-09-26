using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Model.APIModel;

namespace WpfApp1.Model
{
    internal class APICommand
    {
        private static string Url = "http://api.weatherapi.com/v1/forecast.json?key=b65fa7c691a84b10a1c214840231706&lang=ru&q=";
        public static Root Put(string city)
        {
            string json;

            try
            {
                HttpClient clinet = new HttpClient();
                HttpResponseMessage message = clinet.GetAsync(Url + city).Result;

                json = message.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                json = ex.Message;
            }

            return JsonConvert.DeserializeObject<Root>(json);
        }
    }
}
