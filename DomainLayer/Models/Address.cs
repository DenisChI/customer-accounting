using System;
using System.Collections.Generic;

#nullable disable

namespace DomainLayer.Models
{
    public partial class Address
    {
        public Address()
        {
            Clients = new HashSet<Client>();
            Providers = new HashSet<Provider>();
        }

        public int AddressId { get; set; }
        public string AddressInfo { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
    }
}