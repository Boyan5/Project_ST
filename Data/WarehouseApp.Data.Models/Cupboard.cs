using System;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Cupboard : BaseModel<int>
    {
        public int Capacity { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
    }
}
