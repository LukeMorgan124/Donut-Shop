using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string StockLocation { get; set; }

        public Store Store { get; set; }
    }
}