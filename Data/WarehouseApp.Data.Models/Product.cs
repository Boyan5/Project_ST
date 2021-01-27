using System;
using System.ComponentModel.DataAnnotations;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Product : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float Capacity { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int CupboardId { get; set; }
        public virtual Cupboard Cupboard { get; set; }

    }
}
