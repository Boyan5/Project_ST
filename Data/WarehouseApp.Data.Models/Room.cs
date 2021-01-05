using System;
using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Room : BaseModel<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
