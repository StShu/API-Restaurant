using API_Restaurant.Data.Model;
using API_Restaurant.Models.Restaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IGenericRepository<Restaurant> _repository;

        public RestaurantController(IGenericRepository<Restaurant> repository)
        {
            _repository = repository;
        }

        [HttpGet("{name}")]

        public async Task<ActionResult<DetailsResponse>> Details(string name)
        {
            return new DetailsResponse { Restaurant = await _repository.GetMany(r => r.Name == name).FirstOrDefaultAsync() };
        }
    }
}
