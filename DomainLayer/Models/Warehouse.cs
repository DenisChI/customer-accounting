using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            ProductAtStocks = new HashSet<ProductAtStock>();
        }

        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouserFullname { get; set; }

        public virtual ICollection<ProductAtStock> ProductAtStocks { get; set; }
    }
}
