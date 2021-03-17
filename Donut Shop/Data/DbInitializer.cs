using Donut_Shop.Data;
using Donut_Shop.Models;
using System;
using System.Collections.Generic;
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
                return;   
            }

            var products = new Product[]
            {
                new Product{ProductName="Chocolate",Price=3 },
                new Product{ProductName="Cinnamon",Price=4},
                new Product{ProductName="Caramel",Price=4,},
                new Product{ProductName="Strawberry",Price=3,},
                new Product{ProductName="Vanilla",Price=3,},
                new Product{ProductName="Jelly",Price=5},
                new Product{ProductName="Blueberry",Price=4},
                new Product{ProductName="Coffee",Price=6},
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var stores = new Store[]
            {
               new Store{Location="Avondale"},
               new Store{Location="Oratia"},
               new Store{Location="Glen Eden"},
               new Store{Location="Titirangi"},
               new Store{Location="Kelston"},
               new Store{Location="Green Bay"},
               new Store{Location="Blockhouse Bay"},
               new Store{Location="Henderson"},

            };

            context.Stores.AddRange(stores);
            context.SaveChanges();

            if (context.Employees.Any())
            {
                return;   
            }

            var Employees = new Employee[]
            {
                new Employee{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("04/09/2000"), StoreID=1, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Dave",LastName="Nash",DateBirth=DateTime.Parse("17/01/2002"), StoreID=1, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Desiree",LastName="Hopkins",DateBirth=DateTime.Parse("04/08/1989"), StoreID=1, EmployeeType="Food Preparer"},
                new Employee{FirstName="Derek",LastName="Thomson",DateBirth=DateTime.Parse("12/04/1997"), StoreID=1, EmployeeType="Food Preparer"},
                new Employee{FirstName="Annalise",LastName="Johns",DateBirth=DateTime.Parse("23/03/1993"), StoreID=1, EmployeeType="Supervisor"},
                new Employee{FirstName="Kezia",LastName="Castillo",DateBirth=DateTime.Parse("13/08/1977"), StoreID=2, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chase",LastName="Allen",DateBirth=DateTime.Parse("23/10/1983"), StoreID=2, EmployeeType="Food Preparer"},
                new Employee{FirstName="Dolores ",LastName="Powers",DateBirth=DateTime.Parse("22/09/1994"), StoreID=2, EmployeeType="Food Preparer"},
                new Employee{FirstName="Jayson",LastName="Coombes",DateBirth=DateTime.Parse("21/06/1986"), StoreID=2, EmployeeType="Supervisor"},
                new Employee{FirstName="Arwa",LastName="Ford",DateBirth=DateTime.Parse("29/11/1971"), StoreID=3, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chelsea",LastName="Robbins",DateBirth=DateTime.Parse("16/08/1987"), StoreID=3, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Cole",LastName="Palacios",DateBirth=DateTime.Parse("21/09/1994"), StoreID=3, EmployeeType="Food Preparer"},
                new Employee{FirstName="Sana",LastName="Serrano",DateBirth=DateTime.Parse("27/12/1975"), StoreID=3, EmployeeType="Food Preparer"},
                new Employee{FirstName="Teejay",LastName="Beech",DateBirth=DateTime.Parse("25/08/1976"), StoreID=3, EmployeeType="Supervisor"},
                new Employee{FirstName="Vinny",LastName="Silva",DateBirth=DateTime.Parse("27/01/1999"), StoreID=4, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Manal",LastName="Mueller",DateBirth=DateTime.Parse("12/11/2002"), StoreID=4, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alice",LastName="Villarreal",DateBirth=DateTime.Parse("29/04/2002"), StoreID=4, EmployeeType="Food Preparer"},
                new Employee{FirstName="Jadon",LastName="Erickson",DateBirth=DateTime.Parse("18/01/1991"), StoreID=4, EmployeeType="Food Preparer"},
                new Employee{FirstName="Jaxson",LastName="Riggs",DateBirth=DateTime.Parse("14/01/1978"), StoreID=4, EmployeeType="Supervisor"},
                new Employee{FirstName="Zarah",LastName="Wheatley",DateBirth=DateTime.Parse("15/11/1985"), StoreID=5, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Norah",LastName="Vu",DateBirth=DateTime.Parse("19/06/1984"), StoreID=5, EmployeeType="Food Preparer"},
                new Employee{FirstName="Thea",LastName="Ortiz",DateBirth=DateTime.Parse("29/04/1984"), StoreID=5, EmployeeType="Food Preparer"},
                new Employee{FirstName="Marina",LastName="Hodge",DateBirth=DateTime.Parse("21/06/1986"), StoreID=5, EmployeeType="Supervisor"},
                new Employee{FirstName="Katelyn",LastName="Barrett",DateBirth=DateTime.Parse("12/01/1998"), StoreID=6, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Wendy",LastName="Hart",DateBirth=DateTime.Parse("31/03/1997"), StoreID=6, EmployeeType="Food Preparer"},
                new Employee{FirstName="Daniel",LastName="Kenny",DateBirth=DateTime.Parse("24/07/1996"), StoreID=6, EmployeeType="Food Preparer"},
                new Employee{FirstName="Cyrus",LastName="Saunders",DateBirth=DateTime.Parse("03/06/1984"), StoreID=6, EmployeeType="Supervisor"},
                new Employee{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("16/11/1998"), StoreID=7, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alyce",LastName="Stokes",DateBirth=DateTime.Parse("08/04/1983"), StoreID=7, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Neve",LastName="Perry",DateBirth=DateTime.Parse("01/05/2003"), StoreID=7, EmployeeType="Food Preparer"},
                new Employee{FirstName="Catrina",LastName="Crowther",DateBirth=DateTime.Parse("17/08/1987"), StoreID=7, EmployeeType="Food Preparer"},
                new Employee{FirstName="Tyron",LastName="Bradford",DateBirth=DateTime.Parse("05/07/1979"), StoreID=7, EmployeeType="Supervisor"},
                new Employee{FirstName="Matthias",LastName="Liu",DateBirth=DateTime.Parse("14/05/1981"), StoreID=8, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Faith",LastName="Barajas",DateBirth=DateTime.Parse("29/12/1983"), StoreID=8, EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Jessie",LastName="Robles",DateBirth=DateTime.Parse("18/05/1981"), StoreID=8, EmployeeType="Food Preparer"},
                new Employee{FirstName="Zakary",LastName="Laing",DateBirth=DateTime.Parse("22/04/1991"), StoreID=8, EmployeeType="Food Preparer"},
                new Employee{FirstName="Mahira",LastName="Mill",DateBirth=DateTime.Parse("19/10/2002"), StoreID=8, EmployeeType="Supervisor"},
            };

            context.Employees.AddRange(Employees);
            context.SaveChanges();


           List<Stock> stocklevels = new List<Stock>();

            for (int ProductIDCount = 1; ProductIDCount <= products.Length; ProductIDCount++)
            {
                for (int StoreIDCount = 1; StoreIDCount <= stores.Length; StoreIDCount++)
                {
                    Random rd = new Random();
                    int rand_num = rd.Next(0, 50);
                    stocklevels.Add(new Stock(ProductIDCount, StoreIDCount, rand_num));
                    
                }
            }
            context.Stocks.AddRange(stocklevels);
            context.SaveChanges();
        }
    }
}