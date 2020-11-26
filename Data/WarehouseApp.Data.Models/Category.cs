using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Category : BaseModel<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
