using API_Restaurant.Data.Model;
using API_Restaurant.Models.Hall;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HallController : ControllerBase
    {
        private readonly IGenericRepository<Hall> _repository;

        public HallController(IGenericRepository<Hall> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<ListResponse>> List()
        {
            return new ListResponse
            {

                Halls = await _repository.GetAll().Include(r => r.Restaurant).ToArrayAsync(),
            };
        }
        [HttpGet]
        public async Task<ActionResult<ListResponse>> List1()
        {
            return new ListResponse
            {

                Halls = await _repository.GetAll().ToArrayAsync(),
            };
        }
        [HttpGet]
        public async Task<ActionResult<ListResponse>> List2()
        {
            return new ListResponse
            {

                Halls = await _repository.GetAll().Include(r => r.Places).ToArrayAsync(),
            };
        }
    }

}
