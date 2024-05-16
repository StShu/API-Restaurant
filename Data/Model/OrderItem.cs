namespace API_Restaurant.Data.Model
{
    public class OrderItem : Entity
    {
        public Order Order { get; set;}
        public Dish Dish { get; set; }
    }
}
