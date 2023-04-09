using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Stolovaya.API.Models.Store;

namespace Stolovaya.API.Data
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishStore> DishStores { get; set; }
        public DbSet<Store> Stores { get; set; }

        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishStore>().HasKey(u => new { u.StoreId, u.DishId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Stolovaya.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
