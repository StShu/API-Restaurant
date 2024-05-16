namespace API_Restaurant.Data.Model
{
    public class Order : Entity
    {
        public required string FirstName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public Restaurant Restaurant { get; set; }
        public Status Status { get; set; }
        public User User { get; set; }
    }
}
