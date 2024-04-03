using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class Eemployee : Entity
    {
        public int IdUser { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; } = null!;
    }
}
