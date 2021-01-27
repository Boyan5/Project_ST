using WarehouseApp.Data.Common;

namespace WarehouseApp.Data.Models
{
    public class Section : BaseModel<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SectionTypes SectionType { get; set; }
        public int CupboardCapacity { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
