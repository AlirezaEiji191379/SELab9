using Newtonsoft.Json;
using ServiceContracts.DTOs;
using System.Net;
using TripSuggestProject.Abstractions;
using TripSuggestProject.DTOs;

namespace TripSuggestProject
{
    public class TripSuggester : ITripSugesster
    {
        private static readonly Dictionary<string, Location> CityNamesByLocation = new Dictionary<string, Location>()
        {
            { "Tehran", new Location()
                {
                    Latitude = 10,
                    Longitude = 11
                }
            },
            { "Mashhad", new Location() { Latitude= 11,Longitude= 12 } },
            { "Esfehan", new Location() { Latitude = 13,Longitude =  14 } },
            { "Gilan", new Location() { Latitude = 15,Longitude = 16 } },
            { "Mazandaran", new Location() { Latitude = 17, Longitude=18 } }
        };

        public async Task<CityDtos> GetCityDetails(string city)
        {
            var url = $"http://weatherforecastservice:80/Forecast/Weather/{city}";
            var httpRequest = new HttpRequestMessage()
            {
                
                RequestUri = new Uri(url),
                Method = HttpMethod.Get
            };
            using var httpClient = new HttpClient();
            var response = await httpClient.SendAsync(httpRequest);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var weatherForcast = JsonConvert.DeserializeObject<WeatherForecastDto>(jsonResponse);
            return new CityDtos()
            {
                City= city,
                WeatherForecast = weatherForcast,
                Location = CityNamesByLocation[city]
            };
        }
    }
}
