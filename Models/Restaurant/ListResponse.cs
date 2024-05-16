namespace API_Restaurant.Models.Restaurant
{
    public class ListResponse
    {
        public required IReadOnlyCollection<Data.Model.Restaurant> Restaurants { get; set; }
    }
}
