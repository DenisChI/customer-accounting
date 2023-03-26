using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ProductOrderServices
{
    class ProductOrderRepository : Repository<ProductOrder>, IProductOrderRepository
    {
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }
        }

        public ProductOrderRepository(CustomerAccountingContext context) : base(context) { }

        public IEnumerable<ProductOrder> GetProductOrdersByCliendId(int id)
        {
            return Context.Set<ProductOrder>().Where(x => x.ClientId == id).ToList();
        }

        public IEnumerable<ProductOrder> GetOrdersAboveAveragePrice()
        {
            decimal avg = Context.Set<ProductOrder>().Average(x => x.ProductOrderPrice);
            return Context.Set<ProductOrder>().Where(x => x.ProductOrderPrice > avg).ToList();
        }

        public IEnumerable<ProductOrder> GetAllOrdersBetweenDates(DateTime dateBottom, DateTime dateTop)
        {
            return Context.Set<ProductOrder>().Where(x => x.ProductOrderDate > dateBottom.Date && x.ProductOrderDate < dateTop.Date).ToList();
        }

        public IEnumerable<ProductOrder> GetTheMostExpensiveOrdersForEachClient()
        {
            return Context.Set<ProductOrder>().Where(p => p.ProductOrderPrice == Context.Set<Client>().Where(c => c.ClientId == p.ClientId).SelectMany(c=>c.ProductOrders).Max(cpo=>cpo.ProductOrderPrice)).ToList();
        }

        //public ProductOrder GetMostPurchasedProduct()
        //{
        //    //return Context.Set<ProductOrder>().Where(po => po.ProductOrderPrice == Context.Set<Product>().Where(p => p.ProductId == po.ProductId).SelectMany(p => p.ProductOrders).Sum(ppo => ppo.ProductOrderQuantity)).First();
        //    //return Context.Set<ProductOrder>().GroupBy(x => x.ClientId).OrderBy(x=>x.First().ClientId))

        //}

        //public IEnumerable<ProductOrder> GetClientWhoBoughtTheMostInTheTimePeriod(DateTime periodStart, DateTime periodEnd)
        //{
        //    //return Context.Set<ProductOrder>().Where(x => x.ProductOrderDate > periodStart.Date && x.ProductOrderDate < periodEnd.Date).ToList();
        //}
    }
}