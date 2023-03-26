using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductAtStocks = new HashSet<ProductAtStock>();
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int ProductId { get; set; }
        public int ProviderId { get; set; }
        public string ProductName { get; set; }
        public float ProductSellingPrice { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual ICollection<ProductAtStock> ProductAtStocks { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
