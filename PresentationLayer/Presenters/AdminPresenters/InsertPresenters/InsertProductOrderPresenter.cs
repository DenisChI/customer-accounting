using System;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertProductOrderPresenter : IInsertProductOrderPresenter
    {
        private IInsertProductOrderView _view;
        private ProductOrder _productOrder;

        public InsertProductOrderPresenter(IInsertProductOrderView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertProductOrderView GetInsertView() { return _view; }
        public ProductOrder GetProductOrder() { return _productOrder; }
        
        public void InitAddForm()
        {
            _view.Date = DateTime.Now;
            _view.OrderState = string.Empty;
            _view.PaymentType = string.Empty;
            _view.ProductQuantity = 1;
            _view.Price = 0;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var productsNames = unit.Products.GetAllNames();
                _view.Products.DataSource = productsNames;
                var clientsNames = unit.Clients.GetAllNames();
                _view.Clients.DataSource = clientsNames;
                var discountsNames = unit.Discounts.GetAllNames();
                _view.Discounts.DataSource = discountsNames;
            }
        }
        
        private void OnAddButtonClick()
        {
            _productOrder = new ProductOrder();
            _productOrder.ProductOrderQuantity = _view.ProductQuantity;
            _productOrder.ProductOrderPrice = _view.Price;
            _productOrder.ProductOrderDate = _view.Date;
            _productOrder.OrderState = _view.OrderState;
            _productOrder.PaymentType = _view.PaymentType;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Client c = unit.Clients.Find(x => x.ClientFullName.Equals(_view.Clients.SelectedValue)).Single();
                c.ProductOrders.Add(_productOrder);
                Product p = unit.Products.Find(x => x.ProductName.Equals(_view.Products.SelectedValue)).Single();
                p.ProductOrders.Add(_productOrder);
                Discount d = unit.Discounts.Find(x => x.DiscountName.Equals(_view.Discounts.SelectedValue)).Single();
                d.ProductOrders.Add(_productOrder);
                unit.Complete();
            }
        }

        private void OnCancelButtonClick()
        {
            _productOrder = null;
        }
    }
}