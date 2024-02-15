namespace API_Restaurant.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Role : Entity
    {
        public required string Name { get; set; }
    }
}
