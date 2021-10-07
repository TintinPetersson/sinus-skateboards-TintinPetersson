using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinusSkateboards.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusSkateboards.DAL.Database
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }
        public AuthDbContext()
        {

        }
        public virtual DbSet<CustomerModel> Customer { get; set; }
        public virtual DbSet<OrderModel> Orders { get; set; }
        public virtual DbSet<ProductModel> Products { get; set; }
        public virtual DbSet<OrderProductModel> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SinusSkateboardsDb;Trusted_Connection=True;").UseLazyLoadingProxies();
            }
        }
    }
}
