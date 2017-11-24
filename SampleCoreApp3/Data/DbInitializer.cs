using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreApp3.Models;

namespace SampleCoreApp3.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if(context.Products.Any())
            {
                return;
            }
            var products = new List<Product>
            {
                new Product{Name="NoteBook",Price=5},
                new Product{Name="CellPhone",Price=1800},
                new Product{Name="CD Player",Price=30},
                new Product{Name="Jewelry",Price=800}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
