using API_Restaurant.Data.Model;
using API_Restaurant.Models.Dish;
using API_Restaurant.Models.Home;
using API_Restaurant.Models.Restaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IGenericRepository<Restaurant> _repository;

        public RestaurantController(IGenericRepository<Restaurant> repository)
        {
            _repository = repository;
        }

        [HttpGet("{code}")]

        public async Task<ActionResult<DetailsResponse>> Details(string code)
        {
            return new DetailsResponse
            {
                Restaurant = await _repository.GetMany(r => r.Code == code).Include(m=>m.Menues).FirstOrDefaultAsync()
            };
        }
        [HttpGet("/api/[controller]/")]

        public async Task<ActionResult<ListResponse>> List()
        {
            return new ListResponse 
            { 
                Restaurants = await _repository.GetAll().ToArrayAsync() 
            };
        }
    }
}
