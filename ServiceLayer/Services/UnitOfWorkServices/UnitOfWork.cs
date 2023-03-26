using DomainLayer.Models;
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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerAccountingContext _context;

        public IAddressRepository Addresses { get; private set; }
        public IClientRepository Clients { get; private set; }
        public IDiscountRepository Discounts { get; private set; }
        public IProviderRepository Providers { get; private set; }
        public IProductRepository Products { get; private set; }
        public IWarehouseRepository Warehouses { get; private set; }
        public IProductAtStockRepository ProductAtStocks { get; private set; }
        public IProductOrderRepository ProductOrders { get; private set; }

        public UnitOfWork(CustomerAccountingContext context)
        {
            _context = context;
            Addresses = new AddressRepository(_context);
            Clients = new ClientRepository(_context);
            Discounts = new DiscountRepository(_context);
            Providers = new ProviderRepository(_context);
            Products = new ProductRepository(_context);
            Warehouses = new WarehouseRepository(_context);
            ProductAtStocks = new ProductAtStockRepository(_context);
            ProductOrders = new ProductOrderRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}