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

        public IList<Employee> Employees { get; set; }

        public async Task OnGetAsync()
        {
          

            Employees = await _context.Employees
                .Include(c => c.Store)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
