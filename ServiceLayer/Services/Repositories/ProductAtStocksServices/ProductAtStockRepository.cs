using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ProductAtStocksServices
{
    public class ProductAtStockRepository : Repository<ProductAtStock>, IProductAtStockRepository
    {

        public ProductAtStockRepository(CustomerAccountingContext context) : base(context)
        {

        }
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }

        }
    }
}