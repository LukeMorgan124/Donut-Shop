using System;
using System.Collections.Generic;

namespace Donut_Shop.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeType { get; set; }
        public string Location { get; set; }
        public DateTime DateBirth { get; set; }


        public Store Store { get; set; }
    }
}