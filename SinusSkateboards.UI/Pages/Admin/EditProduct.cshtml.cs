using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SinusSkateboards.DAL.Database;
using SinusSkateboards.DTO.Models;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class EditProductModel : PageModel
    {
        private readonly AuthDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public EditProductModel(AuthDbContext Context, IWebHostEnvironment webHostEnvironment)
        {
            context = Context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public SelectList Category { get; set; }
        [BindProperty]
        public ProductModel Product { get; set; }
        public ProductModel OldProduct { get; set; }
        [BindProperty]
        public IFormFile Photo { get; set; }

        public void OnGet(int id)
        {
            Product = context.Products.Where(c => c.Id == id).FirstOrDefault();

            var list = Enum.GetNames<ProductCategory>().ToList();
            Category = new SelectList(list);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            OldProduct = context.Products.Where(c => c.Id == id).FirstOrDefault();

            Product.Id = OldProduct.Id;

            if (Photo != null)
            {
                // Create folder

                Product.Image = "HejDu";

                string folder = Path.Combine(webHostEnvironment.WebRootPath, "images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                // Delete existing photo

                string oldFile = Path.Combine(folder, Product.Image);

                if (System.IO.File.Exists(oldFile))
                {
                    System.IO.File.Delete(oldFile);
                }

                // Upload new photo

                string uniqueFileName = String.Concat(Guid.NewGuid(), "-", Product.Title, ".png");

                string newFile = Path.Combine(folder, uniqueFileName);

                using (var fileStream = new FileStream(newFile, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }

                // Update repo with new photopath

                Product.Image = uniqueFileName;

                context.Products.Remove(OldProduct);
                context.Products.Add(Product);
                await context.SaveChangesAsync();

                return RedirectToPage("/Admin/ProductOverview");
            }


            context.Products.Remove(OldProduct);
            context.Products.Add(Product);
            await context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
