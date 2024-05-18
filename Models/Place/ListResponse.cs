namespace API_Restaurant.Models.Place
{
    public class ListResponse
    {
        public required IReadOnlyCollection<Data.Model.Place> Places { get; set; }
    }
}
