using TripSuggestProject.DTOs;

namespace TripSuggestProject.Abstractions
{
    public interface ITripSugesster
    {
        Task<CityDtos> GetCityDetails(string city);
    }
}
