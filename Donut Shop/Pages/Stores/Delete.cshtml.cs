﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Donut_Shop.Data;
using Donut_Shop.Models;

namespace Donut_Shop.Pages.Stores
{
    public class DeleteModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public DeleteModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Store Store { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Store = await _context.Stores.FirstOrDefaultAsync(m => m.StoreID == id);

            if (Store == null)
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

            Store = await _context.Stores.FindAsync(id);

            if (Store != null)
            {
                _context.Stores.Remove(Store);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
