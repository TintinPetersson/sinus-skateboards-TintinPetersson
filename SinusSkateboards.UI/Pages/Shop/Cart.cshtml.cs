using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class CartModel : PageModel
    {
        public List<ProductModel> Products { get; set; }
        public decimal Sum { get; set; }

        public void OnGet()
        {
            string stringProduct = HttpContext.Session.GetString("Cart");

            if (!String.IsNullOrEmpty(stringProduct))
            {
                Products = JsonConvert.DeserializeObject<List<ProductModel>>(stringProduct);
            }

            foreach (var product in Products)
            {
                Sum += product.Price;
            }
        }
    }
}
