using API_Restaurant.Data.Model;
using API_Restaurant.Models.Place;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly IGenericRepository<Place> _repository;

        public PlaceController(IGenericRepository<Place> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ListResponse>> List()
        {
            return new ListResponse
            {
                Places = await _repository.GetAll().Include(h=>h.Hall).ToArrayAsync(),
            };
        }

    }
}
