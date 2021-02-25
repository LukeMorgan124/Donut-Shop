using Donut_Shop.Data;
using Donut_Shop.Models;
using System;
using System.Linq;

namespace Donut_Shop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product{ProductName="Chocolate",Price=5,StockLocation="Avondale, Glen Eden, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Cinnamon",Price=6,StockLocation="Glen Eden, Oritia, Kelston, Green Bay, Henderson"},
                new Product{ProductName="Caramel",Price=8,StockLocation="Avondale, Oritia, Titirangi, Blockhouse Bay"},
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var staff = new Staff[]
            {              
            };

            context.Staff.AddRange(staff);
            context.SaveChanges();

            var stores = new Store[]
            {               
            };

            context.Store.AddRange(stores);
            context.SaveChanges();
        }
    }
}