using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class Dish : Entity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public float Price { get; set; }
        public int Weight { get; set; }
        public int DishCategoryId { get; set; }
        public string imgsrc { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public DishCategory DishCategory { get; set; } = null!;
    }
}
