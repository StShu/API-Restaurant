using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Model
{
    public class Place : Entity
    {
        public int TableNumber { get; set; }
        public int NumberMets { get; set; }
        public int HallRestaurantId { get; set; }
        public Hall Hall { get; set; } = null!;

    }
}
