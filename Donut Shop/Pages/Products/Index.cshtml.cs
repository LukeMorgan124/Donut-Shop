using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Donut_Shop.Data;
using Donut_Shop.Models;

namespace Donut_Shop.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Donut_Shop.Data.ShopContext _context;
        public IndexModel(Donut_Shop.Data.ShopContext context)
        {
            _context = context;
        }
        public string NameSort { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Product> Product { get; set; }

        public PaginatedList<Product> Products { get; set; }

        public async Task OnGetAsync(string sortOrder,
        string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name";
            PriceSort = sortOrder == "Price" ? "price_desc" : "Price";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Product> productsIQ = from s in _context.Products
                                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                productsIQ = productsIQ.Where(s => s.ProductName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    productsIQ = productsIQ.OrderByDescending(s => s.ProductName);
                    break;
                case "name":
                    productsIQ = productsIQ.OrderBy(s => s.ProductName);
                    break;
                case "Price":
                    productsIQ = productsIQ.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    productsIQ = productsIQ.OrderByDescending(s => s.Price);
                    break;
                default:
                    productsIQ = productsIQ.OrderBy(s => s.Price);
                    break;
            }

            Product = await productsIQ.AsNoTracking().ToListAsync();

            int pageSize = 3;
            Products = await PaginatedList<Product>.CreateAsync(
                productsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
