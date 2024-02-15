using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class Restaurant : Entity
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public ICollection<Menu> Menues { get; set; } = new List<Menu>();
        public ICollection<Hall> Halls { get; set; } = new List<Hall>();
    }
}
