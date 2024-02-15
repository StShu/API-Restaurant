using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class DishCategory : Entity
    {
        public required string Name { get; set; }
    }
}