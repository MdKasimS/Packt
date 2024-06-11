using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    public class Northwind: DbContext
    {
        DbSet<Category> Categories  { get; set; }
        DbSet<Product> Products{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "No");
        }
    }
}