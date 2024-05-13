using API_Restaurant.Data.Model;
using API_Restaurant.Models.Dish;
using API_Restaurant.Models.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]")]
    public class DishController : ControllerBase
    {
        private readonly IGenericRepository<Dish> _repository;

        public DishController(IGenericRepository<Dish> repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DishResponse>> Home(int id)
        {
            return new DishResponse { Dish = _repository.Get(id)};
        }

    }
}
