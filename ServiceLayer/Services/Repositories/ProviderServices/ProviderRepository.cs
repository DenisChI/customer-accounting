using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ProviderServices
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }

        }
        public ProviderRepository(CustomerAccountingContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllNames()
        {
            return Context.Set<Provider>().Select(x => x.ProviderCompanyName).ToList();
        }
        public IEnumerable<string> GetAllEmails()
        {
            return Context.Set<Provider>().Select(x => x.ProviderEmail).ToList();
        }

        /// <summary>
        /// Каскадное удаление.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            List<Product> products = Context.Set<Product>().Where(x => x.ProviderId == id).ToList();
            List<ProductOrder> productOrders;
            List<ProductAtStock> productAtStocks;
            foreach (Product product in products)
            {
                productOrders = Context.Set<ProductOrder>().Where(x => x.ProductId == product.ProductId).ToList();
                Context.Set<ProductOrder>().RemoveRange(productOrders);
                productAtStocks = Context.Set<ProductAtStock>().Where(x => x.ProductId == product.ProductId).ToList();
                Context.Set<ProductAtStock>().RemoveRange(productAtStocks);
            }
            Context.Set<Product>().RemoveRange(products);
            Provider provider = Context.Set<Provider>().Find(id);
            Context.Set<Provider>().Remove(provider);
        }
    }
}