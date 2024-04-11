namespace API_Restaurant.Models.Menu
{
    public class DetailsResponse
    {
        public required Data.Model.Menu? Menu { get; set; }
        public required IReadOnlyCollection<Data.Model.DishCategory?> DishCategories { get; set; }

    }
}
