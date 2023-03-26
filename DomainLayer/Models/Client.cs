using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Client
    {
        public Client()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int ClientId { get; set; }
        public string ClientUsername { get; set; }
        public string ClientPassword { get; set; }
        public string ClientFullName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public int? AddressId { get; set; }
        public string ClientEmail { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}