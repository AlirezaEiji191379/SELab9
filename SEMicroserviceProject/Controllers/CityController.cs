using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripSuggestProject.Abstractions;

namespace TripSuggestProject.Controllers
{
    [Route("CityDetails")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ITripSugesster _tripSugesster;

        public CityController(ITripSugesster tripSugesster)
        {
            _tripSugesster = tripSugesster;
        }

        [HttpGet]
        [Route("{city}")]
        public async Task<IActionResult> GetCityDetail(string city)
        {
           var cityDetail = await _tripSugesster.GetCityDetails(city);
           if(cityDetail == null)
           {
                return NotFound(new {Message= "there is no city with this name"});    
           }
           return Ok(cityDetail);   
        }
    }
}
