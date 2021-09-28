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
    public class CheckoutModel : PageModel
    {
        private readonly AuthDbContext context;
        public List<ProductModel> Products { get; set; }
        [BindProperty]
        public CustomerModel Customer { get; set; } = new CustomerModel();
        public OrderModel Order { get; set; } = new OrderModel();
        public int hej { get; set; }
        public CheckoutModel(AuthDbContext context)
        {
            this.context = context;
        }
        public decimal Sum { get; set; }

        public void OnGet()
        {
            string stringProduct = HttpContext.Session.GetString("Cart");

            if (!String.IsNullOrEmpty(stringProduct))
            {
                Products = JsonConvert.DeserializeObject<List<ProductModel>>(stringProduct);
                foreach (var product in Products)
                {
                    Sum += product.Price;
                }
            }
        }
        public async Task<IActionResult> OnPost()
        {
            string stringProduct = HttpContext.Session.GetString("Cart");

            Products = JsonConvert.DeserializeObject<List<ProductModel>>(stringProduct);
            foreach (var product in Products)
            {
                Sum += product.Price;
            }

            var listOfProducts = new List<ProductModel>();

            foreach (var product in Products)
            {
                listOfProducts.Add(context.Products.Where(c => c.Id == product.Id).FirstOrDefault());
            }


            Order.Date = DateTime.Now;
            Order.Customer = Customer;
            Order.OrderNumber = Guid.NewGuid().GetHashCode();
            Order.Products = new List<ProductModel>();

            foreach (var product in listOfProducts)
            {
                Order.Products.Add(product);
            }

            hej = 1;
            
            await context.Orders.AddAsync(Order);
            await context.SaveChangesAsync();

            Products.Clear();
            stringProduct = JsonConvert.SerializeObject(Products);
            HttpContext.Session.SetString("Cart", stringProduct);

            return Page();
        }
    }
}
