using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseApp.Data.DTO.BindingModels
{
    public class WithdrawProductInputModel
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
