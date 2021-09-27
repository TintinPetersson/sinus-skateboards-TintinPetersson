using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class ProductShopModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        private readonly AuthDbContext context;

        public ProductShopModel(AuthDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Products = context.Products.ToList();
        }
    }
}
