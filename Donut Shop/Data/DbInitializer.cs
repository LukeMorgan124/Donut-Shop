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
                new Product{ProductName="Cinnamon",Price=4,StockLocation="Glen Eden, Oritia, Kelston, Green Bay, Henderson"},
                new Product{ProductName="Caramel",Price=4,StockLocation="Avondale, Oritia, Titirangi, Blockhouse Bay"},
                new Product{ProductName="Strawberry",Price=3,StockLocation="Avondale, Glen Eden, Titirangi, Kelston, Blockhouse Bay"},
                new Product{ProductName="Vanilla",Price=3,StockLocation="Avondale, Oritia, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Jelly",Price=5,StockLocation="Oritia, Titirangi, Kelston, Blockhouse Bay, Henderson"},
                new Product{ProductName="Blueberry",Price=4,StockLocation="Avondale, Glen Eden, Oritia, Titirangi, Kelston, Green Bay, Blockhouse Bay, Henderson"},
                new Product{ProductName="Coffee",Price=6,StockLocation="Glen Eden, Oritia, Kelston, Green Bay"},
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var staff = new Staff[]
            {
                new Staff{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("04/09/2000"), Location="Avondale", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Dave",LastName="Nash",DateBirth=DateTime.Parse("17/01/2002"), Location="Avondale", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Desiree",LastName="Hopkins",DateBirth=DateTime.Parse("04/08/1989"), Location="Avondale", StaffType="Food Preparer"},
                new Staff{FirstName="Derek",LastName="Thomson",DateBirth=DateTime.Parse("12/04/1997"), Location="Avondale", StaffType="Food Preparer"},
                new Staff{FirstName="Annalise",LastName="Johns",DateBirth=DateTime.Parse("23/03/1993"), Location="Avondale", StaffType="Supervisor"},
                new Staff{FirstName="Kezia",LastName="Castillo",DateBirth=DateTime.Parse("13/08/1977"), Location="Oritia", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Chase",LastName="Allen",DateBirth=DateTime.Parse("23/10/1983"), Location="Oritia", StaffType="Food Preparer"},
                new Staff{FirstName="Dolores ",LastName="Powers",DateBirth=DateTime.Parse("22/09/1994"), Location="Oritia", StaffType="Food Preparer"},
                new Staff{FirstName="Jayson",LastName="Coombes",DateBirth=DateTime.Parse("21/06/1986"), Location="Oritia", StaffType="Supervisor"},
                new Staff{FirstName="Arwa",LastName="Ford",DateBirth=DateTime.Parse("29/11/1971"), Location="Glen Eden", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Chelsea",LastName="Robbins",DateBirth=DateTime.Parse("16/08/1987"), Location="Glen Eden", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Cole",LastName="Palacios",DateBirth=DateTime.Parse("21/09/1994"), Location="Glen Eden", StaffType="Food Preparer"},
                new Staff{FirstName="Sana",LastName="Serrano",DateBirth=DateTime.Parse("27/12/1975"), Location="Glen Eden", StaffType="Food Preparer"},
                new Staff{FirstName="Teejay",LastName="Beech",DateBirth=DateTime.Parse("25/08/1976"), Location="Glen Eden", StaffType="Supervisor"},
                new Staff{FirstName="Vinny",LastName="Silva",DateBirth=DateTime.Parse("27/01/1999"), Location="Titirangi", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Manal",LastName="Mueller",DateBirth=DateTime.Parse("12/11/2002"), Location="Titirangi", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Alice",LastName="Villarreal",DateBirth=DateTime.Parse("29/04/2002"), Location="Titirangi", StaffType="Food Preparer"},
                new Staff{FirstName="Jadon",LastName="Erickson",DateBirth=DateTime.Parse("18/01/1991"), Location="Titirangi", StaffType="Food Preparer"},
                new Staff{FirstName="Jaxson",LastName="Riggs",DateBirth=DateTime.Parse("14/01/1978"), Location="Titirangi", StaffType="Supervisor"},
                new Staff{FirstName="Zarah",LastName="Wheatley",DateBirth=DateTime.Parse("15/11/1985"), Location="Kelston", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Norah",LastName="Vu",DateBirth=DateTime.Parse("19/06/1984"), Location="Kelston", StaffType="Food Preparer"},
                new Staff{FirstName="Thea",LastName="Ortiz",DateBirth=DateTime.Parse("29/04/1984"), Location="Kelston", StaffType="Food Preparer"},
                new Staff{FirstName="Marina",LastName="Hodge",DateBirth=DateTime.Parse("21/06/1986"), Location="Kelston", StaffType="Supervisor"},
                new Staff{FirstName="Katelyn",LastName="Barrett",DateBirth=DateTime.Parse("12/01/1998"), Location="Green Bay", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Wendy",LastName="Hart",DateBirth=DateTime.Parse("31/03/1997"), Location="Green Bay", StaffType="Food Preparer"},
                new Staff{FirstName="Daniel",LastName="Kenny",DateBirth=DateTime.Parse("24/07/1996"), Location="Green Bay", StaffType="Food Preparer"},
                new Staff{FirstName="Cyrus",LastName="Saunders",DateBirth=DateTime.Parse("03/06/1984"), Location="Green Bay", StaffType="Supervisor"},
                new Staff{FirstName="John",LastName="Carsons",DateBirth=DateTime.Parse("16/11/1998"), Location="Blockhouse Bay", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Alyce",LastName="Stokes",DateBirth=DateTime.Parse("08/04/1983"), Location="Blockhouse Bay", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Neve",LastName="Perry",DateBirth=DateTime.Parse("01/05/2003"), Location="Blockhouse Bay", StaffType="Food Preparer"},
                new Staff{FirstName="Catrina",LastName="Crowther",DateBirth=DateTime.Parse("17/08/1987"), Location="Blockhouse Bay", StaffType="Food Preparer"},
                new Staff{FirstName="Tyron",LastName="Bradford",DateBirth=DateTime.Parse("05/07/1979"), Location="Blockhouse Bay", StaffType="Supervisor"},
                new Staff{FirstName="Matthias",LastName="Liu",DateBirth=DateTime.Parse("14/05/1981"), Location="Henderson", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Faith",LastName="Barajas",DateBirth=DateTime.Parse("29/12/1983"), Location="Henderson", StaffType="Front-End Customer Service"},
                new Staff{FirstName="Jessie",LastName="Robles",DateBirth=DateTime.Parse("18/05/1981"), Location="Henderson", StaffType="Food Preparer"},
                new Staff{FirstName="Zakary",LastName="Laing",DateBirth=DateTime.Parse("22/04/1991"), Location="Henderson", StaffType="Food Preparer"},
                new Staff{FirstName="Mahira",LastName="Mill",DateBirth=DateTime.Parse("19/10/2002"), Location="Henderson", StaffType="Supervisor"},
            };

            context.Staff.AddRange(staff);
            context.SaveChanges();

            var stores = new Store[]
            {
                new Store{Location="Avondale", ProductID=1, StaffID=1, }
            };

            context.Store.AddRange(stores);
            context.SaveChanges();
        }
    }
}