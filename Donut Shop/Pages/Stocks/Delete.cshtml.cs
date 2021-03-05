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
    public class DeleteModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public DeleteModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Stock stock { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            stock = await _context.Stocks
                .Include(s => s.Products)
                .Include(s => s.Store).FirstOrDefaultAsync(m => m.StockID == id);

            if (stock == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            stock = await _context.Stocks.FindAsync(id);

            if (stock != null)
            {
                _context.Stocks.Remove(stock);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
