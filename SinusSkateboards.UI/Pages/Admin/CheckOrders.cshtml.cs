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
    public class CheckOrdersModel : PageModel
    {
        public List<OrderModel> Orders { get; set; }
        public AuthDbContext Context { get; set; } = new AuthDbContext();
        public void OnGet()
        {
            foreach (var order in Context.Orders)
            {
                Orders.Add(order);
            }
        }
    }
}
