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
        [Range(0,5000)]
        public float Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
