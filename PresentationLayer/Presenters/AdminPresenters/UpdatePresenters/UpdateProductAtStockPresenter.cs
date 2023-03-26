using System;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;


namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateProductAtStockPresenter : IUpdateProductAtStockPresenter
    {
        private IUpdateProductAtStockView _view;
        private ProductAtStock _productAtStock;

        public UpdateProductAtStockPresenter(IUpdateProductAtStockView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateProductAtStockView GetView() { return _view; }
        public ProductAtStock GetProductAtStock() { return _productAtStock; }

        public void InitUpdateForm(string productNameing, string warehouseName, int quantity, DateTime date)
        {
            _view.Quantity = quantity;
            _view.Date = date;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var productsNames = unit.Products.GetAllNames();
                _view.ProductNaming.DataSource = productsNames;
                _view.ProductNaming.Text = productNameing;
                var warehousesNames = unit.Warehouses.GetAllWarehousesNames();
                _view.WarehouseName.DataSource = warehousesNames;
                _view.WarehouseName.Text = warehouseName;
            }
        }
        private void OnUpdateButtonClick()
        {
            _productAtStock = new ProductAtStock();
            _productAtStock.ProductAtStockDate = _view.Date;
            _productAtStock.ProductAtStockQuantity = _view.Quantity;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Product productByName = unit.Products.Find(x => x.ProductName.Equals(_view.ProductNaming.SelectedValue)).Single();
                _productAtStock.Product = productByName;
                _productAtStock.ProductId = productByName.ProductId;
                Warehouse warehouseByName = unit.Warehouses.Find(x => x.WarehouseName.Equals(_view.WarehouseName.SelectedValue)).Single();
                _productAtStock.Warehouse= warehouseByName;
                _productAtStock.WarehouseId = warehouseByName.WarehouseId;
            }
        }

        private void OnCancelButtonClick()
        {
            _productAtStock = null;
        }
    }
}