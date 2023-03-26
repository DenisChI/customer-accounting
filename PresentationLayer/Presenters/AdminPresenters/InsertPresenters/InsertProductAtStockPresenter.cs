using System;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertProductAtStockPresenter : IInsertProductAtStockPresenter
    {
        private IInsertProductAtStockView _view;
        private ProductAtStock _productAtStock;

        public InsertProductAtStockPresenter(IInsertProductAtStockView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertProductAtStockView GetInsertView() { return _view; }
        public ProductAtStock GetProductAtStock() { return _productAtStock; }

        public void InitAddForm()
        {
            _view.Quantity = 1;
            _view.Date = DateTime.Now;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var productsNames = unit.Products.GetAllNames();
                _view.ProductNaming.DataSource = productsNames;
                var warehousesNames = unit.Warehouses.GetAllWarehousesNames();
                _view.WarehouseName.DataSource = warehousesNames;
            }
        }

        private void OnAddButtonClick()
        {
            _productAtStock = new ProductAtStock();
            _productAtStock.ProductAtStockDate = _view.Date;
            _productAtStock.ProductAtStockQuantity = _view.Quantity;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Product productByName = unit.Products.Find(x => x.ProductName.Equals(_view.ProductNaming.SelectedValue)).Single();
                productByName.ProductAtStocks.Add(_productAtStock);
                Warehouse warehouseByName = unit.Warehouses.Find(x => x.WarehouseName.Equals(_view.WarehouseName.SelectedValue)).Single();
                warehouseByName.ProductAtStocks.Add(_productAtStock);
                unit.Complete();
            }   
        }

        private void OnCancelButtonClick()
        {
            _productAtStock = null;
        }
    }
}