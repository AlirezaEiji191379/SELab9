using ServiceContracts.DTOs;

namespace WeatherForecastService.Abstractions
{
    public interface ICityWeatherForecastor
    {
        WeatherForecastDto GetWeatherForecast(string city);
    }
}
