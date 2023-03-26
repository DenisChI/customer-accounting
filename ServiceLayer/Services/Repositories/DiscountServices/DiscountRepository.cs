using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.DiscountServices
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {

        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }
        }
        public DiscountRepository(CustomerAccountingContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllNames()
        {
            return Context.Set<Discount>().Select(x => x.DiscountName).ToList();
        }

        /// <summary>
        /// Каскадное удаление.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            List<ProductOrder> productOrders = Context.Set<ProductOrder>().Where(x => x.DiscountId == id).ToList();
            Context.Set<ProductOrder>().RemoveRange(productOrders);
            Discount d = Context.Set<Discount>().Find(id);
            Context.Set<Discount>().Remove(d);
        }
    }
}