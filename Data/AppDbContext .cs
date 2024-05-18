using API_Restaurant.Data.Model;
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
        public DbSet<Eemployee> Eemployees { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
