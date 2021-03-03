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
                new Employee{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("04/09/2000"), Location="Avondale", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Dave",LastName="Nash",DateBirth=DateTime.Parse("17/01/2002"), Location="Avondale", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Desiree",LastName="Hopkins",DateBirth=DateTime.Parse("04/08/1989"), Location="Avondale", EmployeeType="Food Preparer"},
                new Employee{FirstName="Derek",LastName="Thomson",DateBirth=DateTime.Parse("12/04/1997"), Location="Avondale", EmployeeType="Food Preparer"},
                new Employee{FirstName="Annalise",LastName="Johns",DateBirth=DateTime.Parse("23/03/1993"), Location="Avondale", EmployeeType="Supervisor"},
                new Employee{FirstName="Kezia",LastName="Castillo",DateBirth=DateTime.Parse("13/08/1977"), Location="Oratia", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chase",LastName="Allen",DateBirth=DateTime.Parse("23/10/1983"), Location="Oratia", EmployeeType="Food Preparer"},
                new Employee{FirstName="Dolores ",LastName="Powers",DateBirth=DateTime.Parse("22/09/1994"), Location="Oratia", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jayson",LastName="Coombes",DateBirth=DateTime.Parse("21/06/1986"), Location="Oratia", EmployeeType="Supervisor"},
                new Employee{FirstName="Arwa",LastName="Ford",DateBirth=DateTime.Parse("29/11/1971"), Location="Glen Eden", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Chelsea",LastName="Robbins",DateBirth=DateTime.Parse("16/08/1987"), Location="Glen Eden", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Cole",LastName="Palacios",DateBirth=DateTime.Parse("21/09/1994"), Location="Glen Eden", EmployeeType="Food Preparer"},
                new Employee{FirstName="Sana",LastName="Serrano",DateBirth=DateTime.Parse("27/12/1975"), Location="Glen Eden", EmployeeType="Food Preparer"},
                new Employee{FirstName="Teejay",LastName="Beech",DateBirth=DateTime.Parse("25/08/1976"), Location="Glen Eden", EmployeeType="Supervisor"},
                new Employee{FirstName="Vinny",LastName="Silva",DateBirth=DateTime.Parse("27/01/1999"), Location="Titirangi", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Manal",LastName="Mueller",DateBirth=DateTime.Parse("12/11/2002"), Location="Titirangi", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alice",LastName="Villarreal",DateBirth=DateTime.Parse("29/04/2002"), Location="Titirangi", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jadon",LastName="Erickson",DateBirth=DateTime.Parse("18/01/1991"), Location="Titirangi", EmployeeType="Food Preparer"},
                new Employee{FirstName="Jaxson",LastName="Riggs",DateBirth=DateTime.Parse("14/01/1978"), Location="Titirangi", EmployeeType="Supervisor"},
                new Employee{FirstName="Zarah",LastName="Wheatley",DateBirth=DateTime.Parse("15/11/1985"), Location="Kelston", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Norah",LastName="Vu",DateBirth=DateTime.Parse("19/06/1984"), Location="Kelston", EmployeeType="Food Preparer"},
                new Employee{FirstName="Thea",LastName="Ortiz",DateBirth=DateTime.Parse("29/04/1984"), Location="Kelston", EmployeeType="Food Preparer"},
                new Employee{FirstName="Marina",LastName="Hodge",DateBirth=DateTime.Parse("21/06/1986"), Location="Kelston", EmployeeType="Supervisor"},
                new Employee{FirstName="Katelyn",LastName="Barrett",DateBirth=DateTime.Parse("12/01/1998"), Location="Green Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Wendy",LastName="Hart",DateBirth=DateTime.Parse("31/03/1997"), Location="Green Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Daniel",LastName="Kenny",DateBirth=DateTime.Parse("24/07/1996"), Location="Green Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Cyrus",LastName="Saunders",DateBirth=DateTime.Parse("03/06/1984"), Location="Green Bay", EmployeeType="Supervisor"},
                new Employee{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("16/11/1998"), Location="Blockhouse Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Alyce",LastName="Stokes",DateBirth=DateTime.Parse("08/04/1983"), Location="Blockhouse Bay", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Neve",LastName="Perry",DateBirth=DateTime.Parse("01/05/2003"), Location="Blockhouse Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Catrina",LastName="Crowther",DateBirth=DateTime.Parse("17/08/1987"), Location="Blockhouse Bay", EmployeeType="Food Preparer"},
                new Employee{FirstName="Tyron",LastName="Bradford",DateBirth=DateTime.Parse("05/07/1979"), Location="Blockhouse Bay", EmployeeType="Supervisor"},
                new Employee{FirstName="Matthias",LastName="Liu",DateBirth=DateTime.Parse("14/05/1981"), Location="Henderson", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Faith",LastName="Barajas",DateBirth=DateTime.Parse("29/12/1983"), Location="Henderson", EmployeeType="Front-End Customer Service"},
                new Employee{FirstName="Jessie",LastName="Robles",DateBirth=DateTime.Parse("18/05/1981"), Location="Henderson", EmployeeType="Food Preparer"},
                new Employee{FirstName="Zakary",LastName="Laing",DateBirth=DateTime.Parse("22/04/1991"), Location="Henderson", EmployeeType="Food Preparer"},
                new Employee{FirstName="Mahira",LastName="Mill",DateBirth=DateTime.Parse("19/10/2002"), Location="Henderson", EmployeeType="Supervisor"},
            };

            context.Employees.AddRange(Employees);
            context.SaveChanges();

            var stores = new Store[]
            {
                
            };

            context.Store.AddRange(stores);
            context.SaveChanges();
        }
    }
}