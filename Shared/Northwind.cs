using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    public class Northwind: DbContext
    {
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Product> Products{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            // string path = System.IO.Path.Combine(".//", "NorthwindDb.db");

            optionsBuilder.UseSqlite("Data Source=NorthwindDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().
            Property(Category => Category.CategoryName)
            .IsRequired()
            .HasMaxLength(15);
        }
    }
}