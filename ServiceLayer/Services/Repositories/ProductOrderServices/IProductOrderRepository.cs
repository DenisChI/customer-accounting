using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ProductOrderServices
{
    public interface IProductOrderRepository : IRepository<ProductOrder>
    {
        public IEnumerable<ProductOrder> GetProductOrdersByCliendId(int id);
        public IEnumerable<ProductOrder> GetOrdersAboveAveragePrice();
        public IEnumerable<ProductOrder> GetAllOrdersBetweenDates(DateTime dateBottom, DateTime dateTop);

        public IEnumerable<ProductOrder> GetTheMostExpensiveOrdersForEachClient();

        //public ProductOrder GetMostPurchasedProduct();

        //public IEnumerable<ProductOrder> GetClientWhoBoughtTheMostInTheTimePeriod(DateTime periodStart, DateTime periodEnd);
    }
}