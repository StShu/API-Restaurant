using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class User : Entity
    {
        public required string Login { get; set; }
        public required string Password { get; set; }
        public string? LastName { get; set; }
        public required string FirstName { get; set; }

    }
}
