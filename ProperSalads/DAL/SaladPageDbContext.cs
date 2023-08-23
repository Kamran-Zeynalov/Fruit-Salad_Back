using Microsoft.EntityFrameworkCore;
using ProperSalads.Models;

namespace ProperSalads.DAL
{
    public class SaladPageDbContext : DbContext
    {
        public SaladPageDbContext(DbContextOptions<SaladPageDbContext> options) : base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<FruitSalad> FruitSalads { get; set; }
        public DbSet<SaladAndFruit> SaladAndFruits { get; set; }
        public DbSet<FruitSaladSize> FruitSaladSizes { get; set; }
        public DbSet<FruitVitamin> FruitSaladVitamins { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FruitsaladImages> FruitsaladImages { get; set; }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Setting>()
        //        .HasIndex(k => k.Key)
        //        .IsUnique();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
