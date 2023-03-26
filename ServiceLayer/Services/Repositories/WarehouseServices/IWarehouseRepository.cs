using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.WarehouseServices
{
    public interface IWarehouseRepository : IRepository<Warehouse>
    {
        public IEnumerable<string> GetAllWarehousesNames();

        public IEnumerable<string> GetAllWarehousersFullnames();
    }
}