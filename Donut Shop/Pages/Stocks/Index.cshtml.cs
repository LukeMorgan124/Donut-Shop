using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Donut_Shop.Data;
using Donut_Shop.Models;

namespace Donut_Shop.Pages.Stocks
{
    public class IndexModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public IndexModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }

        public IList<Stock> Stock { get;set; }

        public async Task OnGetAsync()
        {
            Stock = await _context.Stocks
                .Include(s => s.Products)
                .Include(s => s.Store).ToListAsync();
        }
    }
}
