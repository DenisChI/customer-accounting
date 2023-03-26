using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class ProductAtStock
    {
        public int ProductAtStockId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int ProductAtStockQuantity { get; set; }
        public DateTime ProductAtStockDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
