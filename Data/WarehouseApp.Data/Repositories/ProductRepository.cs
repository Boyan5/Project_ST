using System;
using WarehouseApp.Data.Models;
using WarehouseApp.Data.Repositories.Interfaces;

namespace WarehouseApp.Data.Repositories
{
    public class ProductRepository : DbRepository<Product>, IProductRepository
    {
        public ProductRepository(WarehouseAppDbContext warehouseAppDbContext)
            :base(warehouseAppDbContext)
        {

        }
    }
}
