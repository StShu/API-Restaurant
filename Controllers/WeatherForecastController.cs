using API_Restaurant.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Restaurant.Controllers
{
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult<HomeResponse> Home() 
        {
            return new HomeResponse { Restaurants = new List<Restaurant>() };
        }
    }
}