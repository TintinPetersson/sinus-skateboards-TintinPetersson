using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class CheckoutModel : PageModel
    {
        private readonly AuthDbContext context;
        public CheckoutModel(AuthDbContext context)
        {
            this.context = context;
        }
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
        [BindProperty]
        public CustomerModel Customer { get; set; }
        public OrderModel Order { get; set; } = new OrderModel();
        public DateTime OneDay { get; set; }
        public DateTime ThreeDays { get; set; }
        public bool OrderSuccessful { get; set; }
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

            await context.Customer.AddAsync(Customer);
            await context.SaveChangesAsync();

            Order.Date = DateTime.Now;
            Order.Customer = context.Customer.Where(c => c.Id == Customer.Id).FirstOrDefault();
            Order.OrderNumber = Guid.NewGuid().GetHashCode();
            Order.Products = new List<ProductModel>();

            foreach (var product in Products)
            {
                Order.Products.Add(context.Products.Where(c => c.Id == product.Id).FirstOrDefault());
            }

            OrderSuccessful = true;

            await context.Orders.AddAsync(Order);
            await context.SaveChangesAsync();

            Products.Clear();

            CartModel.ListOfItemsInCart = 0;

            stringProduct = JsonConvert.SerializeObject(Products);
            HttpContext.Session.SetString("Cart", stringProduct);


            OneDay = Order.Date.AddDays(1);
            ThreeDays = Order.Date.AddDays(3);


            while (OneDay.DayOfWeek == DayOfWeek.Saturday || OneDay.DayOfWeek == DayOfWeek.Sunday)
            {
                OneDay.AddDays(1);
            }

            while (ThreeDays.DayOfWeek == DayOfWeek.Saturday || ThreeDays.DayOfWeek == DayOfWeek.Sunday)
            {
                ThreeDays = ThreeDays.AddDays(1);
                if (ThreeDays.DayOfWeek == DayOfWeek.Monday)
                {
                    ThreeDays = ThreeDays.AddDays(1);
                }
            }


            return Page();
        }
    }
}
