namespace API_Restaurant.Data.Model
{
    public class Booking : Entity
    {
        public DateTime BookingЕDateTime { get; set; }
        public required string FirstName { get; set; }
        public required string PhoneNumber { get; set; }
        public int IdPlace { get; set; }
        public int IdUser { get; set; }
        public Place Place { get; set; }
        public User User { get; set; }
    }
}
