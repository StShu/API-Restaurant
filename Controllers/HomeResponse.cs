using API_Restaurant.Model;

namespace API_Restaurant.Controllers
{
    public class HomeResponse
    {
        public required IReadOnlyCollection<Restaurant> Restaurants { get; set; }

    }
}