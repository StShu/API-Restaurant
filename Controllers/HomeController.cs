using API_Restaurant.Data.Model;
using API_Restaurant.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API_Restaurant.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IGenericRepository<Restaurant> _repository;

        public HomeController(IGenericRepository<Restaurant> repository)
        {
            _repository = repository;
        }

        [HttpGet("api/")]
        public async Task<ActionResult<HomeResponse>> Home()
        {
            return new HomeResponse { Restaurants = await _repository.GetAll().ToArrayAsync()};
        }
    }
}