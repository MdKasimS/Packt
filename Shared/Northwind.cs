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
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Northwind.db");

            optionsBuilder.UseSqlite(path);
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