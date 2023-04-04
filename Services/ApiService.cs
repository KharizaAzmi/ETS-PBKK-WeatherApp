using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(String.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid=66f80799c3fb37bfa1706a9e68e2eae0", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(String.Format("https://api.openweathermap.org/data/2.5/forecast?q={city name}&appid=66f80799c3fb37bfa1706a9e68e2eae0", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
