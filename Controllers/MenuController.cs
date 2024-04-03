using API_Restaurant.Data.Model;
using API_Restaurant.Models.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API_Restaurant.Controllers
{
    [Route("api/{restaurantCode}/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IGenericRepository<Menu> _repository;

        public MenuController(IGenericRepository<Menu> repository)
        {
            _repository = repository;
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<DetailsResponse>> Details(string restaurantCode, string code)
        {
            var menu = await _repository.GetMany(r => r.Code == code && r.Restaurant.Code == restaurantCode)
                .Include(r => r.Dishes)
                .FirstOrDefaultAsync();

            return new DetailsResponse
            {
                Menus = menu
            };
        }
    }
}
