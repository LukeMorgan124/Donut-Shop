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
    public class DetailsModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public DetailsModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

      
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees
            .Include(s => s.Store)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.EmployeeID == id);
    
            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
