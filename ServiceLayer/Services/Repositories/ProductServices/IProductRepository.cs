using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ProductServices
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<string> GetAllNames();
    }
}