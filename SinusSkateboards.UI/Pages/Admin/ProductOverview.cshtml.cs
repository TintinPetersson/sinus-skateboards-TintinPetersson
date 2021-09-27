using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class ProductOverview : PageModel
    {
        private readonly AuthDbContext context;
        public List<ProductModel> Products { get; set; }

        public ProductOverview(AuthDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Products = context.Products.ToList();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var product = context.Products.Where(c => c.Id == id).FirstOrDefault();

            context.Products.Remove(product);
            await context.SaveChangesAsync();

            return RedirectToPage("/Admin/ProductOverview");
        }
    }
}
