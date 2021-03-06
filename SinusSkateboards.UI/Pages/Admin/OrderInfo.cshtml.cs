using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class OrderInfoModel : PageModel
    {
        public OrderModel Order { get; set; } = new OrderModel();
        public List<OrderProductModel> Products { get; set; }
        public AuthDbContext Context { get; set; } = new AuthDbContext();
        public decimal Sum { get; set; }
        public void OnGet(int id)
        {
            Order = Context.Orders.Where(c => c.Id == id).FirstOrDefault();

            Products = Context.OrderProducts.Where(c => c.OrderModelId == Order.Id).Include(x => x.ProductModel).ToList();

            foreach (var item in Order.Products)
            {
                Sum += item.ProductModel.Price;
            }
        }
    }
}
