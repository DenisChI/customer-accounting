using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.DiscountServices
{
    public interface IDiscountRepository : IRepository<Discount>
    {
        public IEnumerable<string> GetAllNames();
    }
}