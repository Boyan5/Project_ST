using System;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Services.DataServices.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product, string path);
    }
}
