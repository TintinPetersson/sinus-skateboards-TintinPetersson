using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class ProductShopModel : PageModel
    {
        [BindProperty]
        public ProductCategory CategorySearch { get; set; }
        public List<ProductModel> Products { get; set; }
        private readonly AuthDbContext context;
        public SelectList Category { get; set; }
        public ProductShopModel(AuthDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Products = context.Products.ToList();

            var list = Enum.GetNames<ProductCategory>().ToList();
            Category = new SelectList(list);
        }
        public IActionResult OnPost(string search)
        {
            Products = context.Products.Where(c => c.Title.Contains(search)).ToList();

            if (Products.Count() == 0)
            {
                Products = context.Products.Where(c => c.Color.Contains(search)).ToList();
            }

            if (search == null)
            {
                Products = context.Products.Where(c => c.ProductCategory == CategorySearch).ToList();
            }
          
            return Page();
        }
    }
}
