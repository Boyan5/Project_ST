using System;
using System.Collections.Generic;
using WarehouseApp.Web.DTO;

namespace WarehouseApp.Data.DTO.ViewModels
{
    public class CupboardDetailsViewModel
    {
        public int Id { get; set; }
        public float CapacityPercentage { get; set; }
        public float CapacityLeft { get; set; }
        public float MaxCapacity { get; set; }
        public IEnumerable<ProductViewModel> AllProducts { get; set; }
    }
}
