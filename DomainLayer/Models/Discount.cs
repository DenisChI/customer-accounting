using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Discount
    {
        public Discount()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public float DiscountPerecentage { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}