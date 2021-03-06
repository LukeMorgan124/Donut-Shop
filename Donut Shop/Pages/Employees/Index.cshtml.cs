using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Donut_Shop.Data;
using Donut_Shop.Models;

namespace Donut_Shop.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public IndexModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }
        public string FirstNameSort { get; set; }
        public string LastNameSort { get; set; }
        public string StoreSort { get; set; }
        public string ETSort { get; set; }
        public string DOBSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Employee> Employee { get; set; }

        public class EmployeesPlusStore
        {
            public Employee Employee { get; set; }
            public Store Store { get; set; }
        }

        //public PaginatedList<Employee> Employees { get; set; }
        public PaginatedList<EmployeesPlusStore> Employees { get; set; }

        public async Task OnGetAsync(string sortOrder,
        string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            FirstNameSort = sortOrder == "Fname" ? "Fname_desc" : "Fname";
            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "Lname_desc" : "";
            StoreSort = sortOrder == "Store" ? "Store_desc" : "Store";
            ETSort = sortOrder =="ET" ? "ET_desc" : "ET";
            DOBSort = sortOrder == "DOB" ? "DOB_desc" : "ET";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            //IQueryable<Employee> employeesIQ = from s in _context.Employees 
            //                                 select s;

            IQueryable<EmployeesPlusStore> employeesIQ = from e in _context.Employees
                                                         join s in _context.Stores on e.StoreID equals s.StoreID
                                                         select new EmployeesPlusStore() { Employee = e, Store = s };




            if (!String.IsNullOrEmpty(searchString))
            {
                employeesIQ = employeesIQ.Where(e => e.Employee.FirstName.Contains(searchString)
                                   || e.Employee.LastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Fname":
                    employeesIQ = employeesIQ.OrderBy(s => s.Employee.FirstName);
                    break;
                case "Fname_desc":
                    employeesIQ = employeesIQ.OrderByDescending(s => s.Employee.FirstName);
                    break;
                case "Lname_desc":
                    employeesIQ = employeesIQ.OrderByDescending(s => s.Employee.LastName);
                    break;
                case "Store":
                    employeesIQ = employeesIQ.OrderBy(s => s.Store.Location);
                    break;
                case "Store_desc":
                    employeesIQ = employeesIQ.OrderByDescending(s => s.Store.Location);
                    break;
                case "ET":
                    employeesIQ = employeesIQ.OrderBy(s => s.Employee.EmployeeType);
                    break;
                case "ET_desc":
                    employeesIQ = employeesIQ.OrderByDescending(s => s.Employee.EmployeeType);
                    break;
                case "DOB":
                    employeesIQ = employeesIQ.OrderBy(s => s.Employee.DateBirth);
                    break;
                case "DOB_desc":
                    employeesIQ = employeesIQ.OrderByDescending(s => s.Employee.DateBirth);
                    break;
                default:
                    employeesIQ = employeesIQ.OrderBy(s => s.Employee.LastName);
                    break;
            }


            //Employee = await _context.Employees
            //    .Include(s => s.Store)
            //    .AsNoTracking()
            //    .ToListAsync();

            int pageSize = 8;
            Employees = await PaginatedList<EmployeesPlusStore>.CreateAsync(
                employeesIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
