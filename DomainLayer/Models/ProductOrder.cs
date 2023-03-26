using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int DiscountId { get; set; }
        public string OrderState { get; set; }
        public string PaymentType { get; set; }
        public DateTime ProductOrderDate { get; set; }
        public int ProductOrderQuantity { get; set; }
        public decimal ProductOrderPrice { get; set; }

        public virtual Client Client { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Product Product { get; set; }
    }
}
