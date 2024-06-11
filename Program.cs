using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To .NET World!");
        QueryingCategories();
    }

    static void QueryingCategories()
    {
        var db = new Northwind();

        Console.WriteLine("Categories and how many products they have: ");

        IQueryable<Category> cats = db.Categories
        .Include(c => c.Products);

        foreach(Category c in cats)
        {
            Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products");
        }
    }
}