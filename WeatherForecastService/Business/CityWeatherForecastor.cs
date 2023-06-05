using ServiceContracts.DTOs;
using WeatherForecastService.Abstractions;

namespace WeatherForecastService.Business
{
    public class CityWeatherForecastor : ICityWeatherForecastor
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly List<string> Cities = new List<string>()
        {
            "Tehran",
            "Mashhad",
            "Esfehan",
            "Gilan",
            "Mazandaran"
        };
        public WeatherForecastDto GetWeatherForecast(string city)
        {
            if(!Cities.Contains(city)) 
            {
                return null;
            }
            return new WeatherForecastDto
            {
                City= city,
                Date = DateTime.Now.AddDays(1),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }
    }
}
