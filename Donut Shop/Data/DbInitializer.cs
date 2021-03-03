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
                new Product{ProductName="Chocolate",Price=3,StockLocation="Avondale, Glen Eden, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Cinnamon",Price=4,StockLocation="Glen Eden, Oratia, Kelston, Green Bay, Henderson"},
                new Product{ProductName="Caramel",Price=4,StockLocation="Avondale, Oratia, Titirangi, Blockhouse Bay"},
                new Product{ProductName="Strawberry",Price=3,StockLocation="Avondale, Glen Eden, Titirangi, Kelston, Blockhouse Bay"},
                new Product{ProductName="Vanilla",Price=3,StockLocation="Avondale, Oratia, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Jelly",Price=5,StockLocation="Oritia, Titirangi, Kelston, Blockhouse Bay, Henderson"},
                new Product{ProductName="Blueberry",Price=4,StockLocation="Avondale, Glen Eden, Oratia, Titirangi, Kelston, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Coffee",Price=6,StockLocation="Glen Eden, Oratia, Kelston, Green Bay"},
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var Employees = new Employee[]
            {
                new Employee{FirstName="John",LastName="Carsons",DateBirth="04/09/2000", Location="Avondale", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Dave",LastName="Nash",DateBirth="17/01/2002", Location="Avondale", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Desiree",LastName="Hopkins",DateBirth="04/08/1989", Location="Avondale", EmployeeType="Food Preparer"},
                new Employee{FirstName="Derek",LastName="Thomson",DateBirth="12/04/1997", Location="Avondale", EmployeeType="Food Preparer"},
                new Employee{FirstName="Annalise",LastName="Johns",DateBirth="23/03/1993", Location="Avondale", EmployeeType="Supervisor"},
                new Employee{FirstName="Kezia",LastName="Castillo",DateBirth="13/08/1977", Location="Oratia", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chase",LastName="Allen",DateBirth="23/10/1983", Location="Oratia", EmployeeType="Food Preparer"},
                new Employee{FirstName="Dolores ",LastName="Powers",DateBirth="22/09/1994", Location="Oratia", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jayson",LastName="Coombes",DateBirth="21/06/1986", Location="Oratia", EmployeeType="Supervisor"},
                new Employee{FirstName="Arwa",LastName="Ford",DateBirth="29/11/1971", Location="Glen Eden", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chelsea",LastName="Robbins",DateBirth="16/08/1987", Location="Glen Eden", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Cole",LastName="Palacios",DateBirth="21/09/1994", Location="Glen Eden", EmployeeType="Food Preparer"},
                new Employee{FirstName="Sana",LastName="Serrano",DateBirth="27/12/1975", Location="Glen Eden", EmployeeType="Food Preparer"},
                new Employee{FirstName="Teejay",LastName="Beech",DateBirth="25/08/1976", Location="Glen Eden", EmployeeType="Supervisor"},
                new Employee{FirstName="Vinny",LastName="Silva",DateBirth="27/01/1999", Location="Titirangi", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Manal",LastName="Mueller",DateBirth="12/11/2002", Location="Titirangi", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alice",LastName="Villarreal",DateBirth="29/04/2002", Location="Titirangi", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jadon",LastName="Erickson",DateBirth="18/01/1991", Location="Titirangi", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jaxson",LastName="Riggs",DateBirth="14/01/1978", Location="Titirangi", EmployeeType="Supervisor"},
                new Employee{FirstName="Zarah",LastName="Wheatley",DateBirth="15/11/1985", Location="Kelston", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Norah",LastName="Vu",DateBirth="19/06/1984", Location="Kelston", EmployeeType="Food Preparer"},
                new Employee{FirstName="Thea",LastName="Ortiz",DateBirth="29/04/1984", Location="Kelston", EmployeeType="Food Preparer"},
                new Employee{FirstName="Marina",LastName="Hodge",DateBirth="21/06/1986", Location="Kelston", EmployeeType="Supervisor"},
                new Employee{FirstName="Katelyn",LastName="Barrett",DateBirth="12/01/1998", Location="Green Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Wendy",LastName="Hart",DateBirth="31/03/1997", Location="Green Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Daniel",LastName="Kenny",DateBirth="24/07/1996", Location="Green Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Cyrus",LastName="Saunders",DateBirth="03/06/1984", Location="Green Bay", EmployeeType="Supervisor"},
                new Employee{FirstName="John",LastName="Carsons",DateBirth="16/11/1998", Location="Blockhouse Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alyce",LastName="Stokes",DateBirth="08/04/1983", Location="Blockhouse Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Neve",LastName="Perry",DateBirth="01/05/2003", Location="Blockhouse Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Catrina",LastName="Crowther",DateBirth="17/08/1987", Location="Blockhouse Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Tyron",LastName="Bradford",DateBirth="05/07/1979", Location="Blockhouse Bay", EmployeeType="Supervisor"},
                new Employee{FirstName="Matthias",LastName="Liu",DateBirth="14/05/1981", Location="Henderson", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Faith",LastName="Barajas",DateBirth="29/12/1983", Location="Henderson", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Jessie",LastName="Robles",DateBirth="18/05/1981", Location="Henderson", EmployeeType="Food Preparer"},
                new Employee{FirstName="Zakary",LastName="Laing",DateBirth="22/04/1991", Location="Henderson", EmployeeType="Food Preparer"},
                new Employee{FirstName="Mahira",LastName="Mill",DateBirth="19/10/2002", Location="Henderson", EmployeeType="Supervisor"},
            };

            context.Employees.AddRange(Employees);
            context.SaveChanges();

            var stores = new Store[]
            {
               new Store{Location="Avondale", ProductID=1, EmployeeID=1},
               new Store{Location="Oratia", ProductID=1},
               new Store{Location="Glen Eden", ProductID=1},
               new Store{Location="Titirangi", ProductID=1},
               new Store{Location="Kelston", ProductID=2},
               new Store{Location="Green Bay", ProductID=2},
               new Store{Location="Blockhouse Bay", ProductID=2},
               new Store{Location="Henderson", ProductID=2},

            };

            context.Store.AddRange(stores);
            context.SaveChanges();
        }
    }
}