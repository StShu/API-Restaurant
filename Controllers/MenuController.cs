using API_Restaurant.Data.Model;
using API_Restaurant.Models.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API_Restaurant.Controllers
{
    [Route("api/Restaurant/{restaurantCode}/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IGenericRepository<Menu> _Menurepository;
        private readonly IGenericRepository<DishCategory> _Categoryrepository;

        public MenuController(IGenericRepository<Menu> Menurepository, IGenericRepository<DishCategory> Categoryrepository)
        {
            _Menurepository = Menurepository;
            _Categoryrepository = Categoryrepository;
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<DetailsResponse>> Details(string restaurantCode, string code)
        {
            var menu = await _Menurepository.GetMany(r => r.Code == code && r.Restaurant.Code == restaurantCode)
                .Include(r => r.Dishes)
                .FirstOrDefaultAsync();

            if (menu == null) {
                throw new Exception("EMPTY Menu");
            }
            var categoriesId = menu.Dishes.Select(x => x.DishCategoryId);
            var categories = await _Categoryrepository.GetAll().Where(c => categoriesId.Contains(c.Id)).ToArrayAsync();
            
            return new DetailsResponse
            {
                Menu = menu,
                DishCategories = categories
            };
        }

    }
}
