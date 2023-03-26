using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.AddressServices
{
    public interface IAddressRepository : IRepository<Address>
    {
        Address Get(int? addressId);
        Address GetByInfo(string address);
    }
}
