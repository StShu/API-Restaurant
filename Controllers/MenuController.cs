using API_Restaurant.Data.Model;
using API_Restaurant.Models.Menu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IGenericRepository<Menu> _repository;

        public MenuController(IGenericRepository<Menu> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<DetailsResponse>> Details(string code)
        {
            return new DetailsResponse { Menu = await _repository.GetMany(r => r.Code == code).FirstOrDefaultAsync() };
        }
    }
}
