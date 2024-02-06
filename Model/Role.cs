namespace API_Restaurant.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Role : Entity
    {
        public required string Name { get; set; }
    }
}
