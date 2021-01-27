using System;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Cupboard : BaseModel<int>
    {
        public float MaxCapacity { get; set; }
        public float CapacityLeft { get; set; }
        public bool IsFull { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
    }
}
