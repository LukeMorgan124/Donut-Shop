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

        public Stock(int productID, int storeID, int stockLevel)
        {
            ProductID = productID;
            StoreID = storeID;
            StockLevel = stockLevel;
        }


        public Store Store { get; set; }
        public Product Products { get; set; }
    }
}