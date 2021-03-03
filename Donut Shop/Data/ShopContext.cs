using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Donut_Shop.Models;

namespace Donut_Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Store { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Store>().ToTable("Store");
        }
    }
}
