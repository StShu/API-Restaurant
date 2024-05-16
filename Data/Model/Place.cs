using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restaurant.Data.Model
{
    public class Place : Entity
    {
        public int TableNumber { get; set; }
        public int NumberMets { get; set; }
        public Hall Hall { get; set; } = null!;

    }
}
