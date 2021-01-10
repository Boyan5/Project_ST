using System;
using WarehouseApp.Data.Models;
using WarehouseApp.Data.Repositories.Interfaces;
using WarehouseApp.Services.DataServices.Interfaces;

namespace WarehouseApp.Services.DataServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product CreateProduct(Product productToAdd, string path)
        {
            var product = new Product
            {
                Name = productToAdd.Name,
                Description = productToAdd.Description,
                Price = productToAdd.Price,
                CupboardId = productToAdd.CupboardId,
                Path = path
            };

            return productRepository.AddAsync(product);
        }
    }
}
