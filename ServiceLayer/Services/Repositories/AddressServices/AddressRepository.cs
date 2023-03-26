using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.AddressServices
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }
        }

        public AddressRepository(CustomerAccountingContext context) : base(context) {}

        public Address Get(int? addressId)
        {
            return Context.Set<Address>().SingleOrDefault(x=>x.AddressId == addressId);
        }

        public Address GetByInfo(string address)
        {
            return Context.Set<Address>().SingleOrDefault(x => x.AddressInfo.Equals(address));
        }

        /// <summary>
        /// Каскадное удаление.
        /// </summary>
        /// <param name="id"></param>
        //public void Remove(int id)
        //{
        //List<ProductOrder> productOrders = Context.Set<ProductOrder>().Where(x => x.ClientId == id).ToList();
        //Context.Set<ProductOrder>().RemoveRange(productOrders);
        //Client c = Context.Set<Client>().Find(id);
        //Context.Set<Client>().Remove(c);
        //}
    }
}