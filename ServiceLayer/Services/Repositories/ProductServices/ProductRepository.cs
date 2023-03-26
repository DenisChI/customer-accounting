using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
namespace ServiceLayer.Services.Repositories.ProductServices
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }
        }
        public ProductRepository(CustomerAccountingContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllNames()
        {
            //return Context.Set<Product>().Select(x => new { x.ProviderId, x.ProductName} );
            return Context.Set<Product>().Select(x => x.ProductName).ToList();
        }

        /// <summary>
        /// Каскадное удаление.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            List<ProductOrder> productOrders = Context.Set<ProductOrder>().Where(x => x.ProductId == id).ToList();
            Context.Set<ProductOrder>().RemoveRange(productOrders);
            List<ProductAtStock> productAtStocks = Context.Set<ProductAtStock>().Where(x => x.ProductId == id).ToList();
            Context.Set<ProductAtStock>().RemoveRange(productAtStocks);
            Product product = Context.Set<Product>().Find(id);
            Context.Set<Product>().Remove(product);
        }
    }
}