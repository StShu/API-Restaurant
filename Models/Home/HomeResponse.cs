using API_Restaurant.Data.Model;

namespace API_Restaurant.Models.Home
{
    public class HomeResponse
    {
        public required IReadOnlyCollection<Data.Model.Restaurant> Restaurants { get; set; }
    }
}