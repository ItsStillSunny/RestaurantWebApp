using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Models;

namespace Restaurant.DAL
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<FoodToTable> FoodToTable { get; set; }
    }
}
