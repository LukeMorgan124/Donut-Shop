﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Donut_Shop.Data;
using Donut_Shop.Models;

namespace Donut_Shop.Pages.Stocks
{
    public class CreateModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;

        public CreateModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProductID"] = new SelectList(_context.Products, "ProductID", "ProductID");
            ViewData["StoreID"] = new SelectList(_context.Stores, "StoreID", "StoreID");
            return Page();
        }

        [BindProperty]
        public Stock stock { get; set; }
       
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
