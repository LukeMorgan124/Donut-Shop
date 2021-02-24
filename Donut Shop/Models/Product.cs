using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string StockLocation { get; set; }

        public ICollection<Store> Store { get; set; }
    }
}