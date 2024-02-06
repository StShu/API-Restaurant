using API_Restaurant.Model;
using Microsoft.EntityFrameworkCore;

namespace API_Restaurant.Data
{
   
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCategory> DishCategories { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Menu> Menues { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Restaurant> Restaurants { get; set;}
        
    }
}
