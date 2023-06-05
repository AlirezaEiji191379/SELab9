using Microsoft.AspNetCore.Mvc;
using WeatherForecastService.Abstractions;

namespace WeatherForecastService.Controllers
{
    [ApiController]
    [Route("Forecast")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICityWeatherForecastor _cityWeathorForcastor;

        public WeatherForecastController(ICityWeatherForecastor cityWeatherForecastor)
        {
            _cityWeathorForcastor = cityWeatherForecastor;
        }

        [HttpGet]
        [Route("Weather/{city}")]
        public IActionResult Get(string city)
        {
            var cityWeather = _cityWeathorForcastor.GetWeatherForecast(city);
            if(cityWeather == null)
            {
                return NotFound(new {Message = "this city does not exist!"});
            }
            return Ok(cityWeather);    
        }
    }
}