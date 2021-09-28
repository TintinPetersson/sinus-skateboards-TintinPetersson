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
    public class CheckOrderModel : PageModel
    {
        public bool OrderExists { get; set; }
        public OrderModel Order { get; set; }
        private readonly AuthDbContext context;
        public CheckOrderModel(AuthDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(string search)
        {
            int orderNo = int.Parse(search);

            Order = context.Orders.Where(c => c.OrderNumber == orderNo).FirstOrDefault();

            OrderExists = true;

            return Page();
        }
    }
}
