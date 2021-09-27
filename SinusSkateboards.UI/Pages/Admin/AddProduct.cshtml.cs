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
    public class AddProductModel : PageModel
    {
        public SelectList Category { get; set; }
        private readonly AuthDbContext context;
        [BindProperty]
        public ProductModel Product { get; set; }
        public IWebHostEnvironment WebHostEnvironment { get; }
        [BindProperty]
        public IFormFile Photo { get; set; }

        public AddProductModel(AuthDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            WebHostEnvironment = webHostEnvironment;
        }
        public void OnGet()
        {
            var list = Enum.GetNames<ProductCategory>().ToList();
            Category = new SelectList(list);
        }
        public async Task<IActionResult> OnPost()
        {
            if (Photo != null)
            {
                // Create folder
                if (Product.Image == null)
                {
                    Product.Image = "HejDu";
                }

                string folder = Path.Combine(WebHostEnvironment.WebRootPath, "images");

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

                await context.Products.AddAsync(Product);
                await context.SaveChangesAsync();

                return RedirectToPage("/Index");
            }

            return RedirectToPage("/Index");
        }
    }
}
