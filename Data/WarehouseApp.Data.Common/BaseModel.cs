using System;

namespace WarehouseApp.Data.Common
{
    public class BaseModel<T> : ICreatable
    {
        public T Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
