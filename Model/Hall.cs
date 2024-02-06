using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_Restaurant.Model
{
    public class Hall : Entity
    {
        public required string Name { get; set; }
        public required Restaurant Restaurant { get; set; }
        public ICollection<Place> Places { get; set; } = new List<Place>();
    }
}
