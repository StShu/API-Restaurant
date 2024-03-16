using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class Menu : Entity
    {
        public required Restaurant Restaurant { get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }

        public Menu()
        {
            Dishes = new List<Dish>();
        }
    }
}
