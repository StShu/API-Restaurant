using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Model
{
    public class Menu : Entity
    {
        public required Restaurant Restaurant { get; set;}
        public ICollection<Dish> Dishes { get; set; } = new List<Dish>(); 
    }
}
