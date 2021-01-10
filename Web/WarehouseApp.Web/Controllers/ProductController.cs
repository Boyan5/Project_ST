using System;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.DataServices.Interfaces;

namespace WarehouseApp.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IHostingEnvironment enviroment;

        public ProductController(IProductService productService, IHostingEnvironment enviroment)
        {
            this.productService = productService;
            this.enviroment = enviroment;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
    [Bind("Name,Description,CreatedOn,Price,CupboardId")] Product product, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length != 0)
                {
                    //Create a File Info
                    FileInfo fi = new FileInfo(file.FileName);

                    var art = productService.CreateProduct(product, fi.Extension);

                    //This code creates a unique file name to prevent duplications
                    //stored at the file location
                    var newFileName = art.ToString() + fi.Extension;
                    var webPath = enviroment.WebRootPath;
                    var path = Path.Combine("", webPath + @"/images/arts/" + newFileName);

                    //IMPORTANT: the pathToSave variable will be save on the column in the database
                    //var pathToSave = @"/images/" + newFileName;

                    //This stream the physical file to the allocate wwwroot/images folder
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
