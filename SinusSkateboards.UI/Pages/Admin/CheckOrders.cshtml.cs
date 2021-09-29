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
    public class CheckOrdersModel : PageModel
    {
        public AuthDbContext context = new AuthDbContext();
        public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
        public void OnGet()
        {
            Orders = context.Orders.Include("Products").ToList();
        }
    }
}
