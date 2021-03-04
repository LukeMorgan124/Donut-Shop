using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}