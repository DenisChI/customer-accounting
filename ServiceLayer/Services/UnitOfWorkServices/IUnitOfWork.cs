using System;
using ServiceLayer.Services.Repositories.AddressServices;
using ServiceLayer.Services.Repositories.ClientServices;
using ServiceLayer.Services.Repositories.DiscountServices;
using ServiceLayer.Services.Repositories.ProviderServices;
using ServiceLayer.Services.Repositories.ProductServices;
using ServiceLayer.Services.Repositories.WarehouseServices;
using ServiceLayer.Services.Repositories.ProductAtStocksServices;
using ServiceLayer.Services.Repositories.ProductOrderServices;

namespace ServiceLayer.Services.UnitOfWorkServices
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        IClientRepository Clients { get; }
        IDiscountRepository Discounts { get; }
        IProviderRepository Providers { get; }
        IProductRepository Products { get; }
        IWarehouseRepository Warehouses { get; }
        IProductAtStockRepository ProductAtStocks { get; }
        IProductOrderRepository ProductOrders { get; }
        int Complete();
    }
}
