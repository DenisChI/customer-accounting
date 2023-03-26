using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.WarehouseServices
{
    class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }

        }
        public WarehouseRepository(CustomerAccountingContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllWarehousesNames()
        {
            return Context.Set<Warehouse>().Select(x => x.WarehouseName).ToList();
        }

        public IEnumerable<string> GetAllWarehousersFullnames()
        {
            return Context.Set<Warehouse>().Select(x => x.WarehouserFullname).ToList();
        }

        public void Remove(int id)
        {
            List<ProductAtStock> productAtStocks = Context.Set<ProductAtStock>().Where(x => x.WarehouseId == id).ToList();
            Context.Set<ProductAtStock>().RemoveRange(productAtStocks);
            Warehouse w = Context.Set<Warehouse>().Find(id);
            Context.Set<Warehouse>().Remove(w);
        }
    }
}