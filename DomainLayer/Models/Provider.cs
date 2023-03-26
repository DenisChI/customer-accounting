using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Products = new HashSet<Product>();
        }

        public int ProviderId { get; set; }
        public string ProviderCompanyName { get; set; }
        public string ProviderPhoneNumber { get; set; }
        public int? AddressId { get; set; }
        public string ProviderEmail { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
