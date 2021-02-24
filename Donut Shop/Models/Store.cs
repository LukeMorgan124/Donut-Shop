using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Location { get; set; }
        public int ProductID { get; set; }
        public int StaffID { get; set; }

        public Product Product { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}