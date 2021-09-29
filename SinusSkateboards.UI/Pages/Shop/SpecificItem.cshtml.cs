using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class SpecificItemModel : PageModel
    {
        private readonly AuthDbContext context;
        public ProductModel Product { get; set; }
        public List<ProductModel> SameCategory { get; set; }
        public SpecificItemModel(AuthDbContext Context)
        {
            context = Context;
        }
        public void OnGet(int id)
        {
            Product = context.Products.Where(c => c.Id == id).FirstOrDefault();
            SameCategory = context.Products.Where(c => c.ProductCategory == Product.ProductCategory).ToList();
            SameCategory.Remove(Product);
        }
        public IActionResult OnPost(int id)
        {
            Product = context.Products.Where(c => c.Id == id).FirstOrDefault();


            string stringProduct = HttpContext.Session.GetString("Cart");

            List<ProductModel> products = new();

            if (!String.IsNullOrEmpty(stringProduct))
            {
                products = JsonConvert.DeserializeObject<List<ProductModel>>(stringProduct);
            }

            products.Add(Product);

            CartModel.ListOfItemsInCart++;

            stringProduct = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("Cart", stringProduct);

            return RedirectToPage("/Shop/ProductShop");
        }
    }
}
