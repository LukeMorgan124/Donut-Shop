using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Location { get; set; }
        public int ProductID { get; set; }
        public int EmployeeID { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}