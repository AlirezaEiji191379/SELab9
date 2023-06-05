using ServiceContracts.DTOs;

namespace TripSuggestProject.DTOs
{
    public class CityDtos
    {
        public string City { get; set; }
        public WeatherForecastDto WeatherForecast { get; set; }
        public Location Location { get; set; }

    }
    public class Location
    {
        public long Latitude { get; set; }
        public long Longitude { get; set; }
    }

}
