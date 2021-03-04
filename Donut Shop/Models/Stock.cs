using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public int StoreID { get; set; }
        public int StockLevel { get; set; }


        public Store Store { get; set; }
        public Product Product { get; set; }
    }
}