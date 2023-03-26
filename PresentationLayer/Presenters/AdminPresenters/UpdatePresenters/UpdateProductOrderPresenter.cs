using System;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateProductOrderPresenter : IUpdateProductOrderPresenter
    {
        private IUpdateProductOrderView _view;
        private ProductOrder _productOrder;
        public UpdateProductOrderPresenter(IUpdateProductOrderView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateProductOrderView GetView() { return _view; }
        public ProductOrder GetProductOrder() { return _productOrder; }

        public void InitUpdateForm(string productName, string clientFullName, int quantity, string paymentType, string orderState, string discountName, DateTime date, decimal price)
        {
            _view.ProductQuantity = quantity;
            _view.PaymentType = paymentType;
            _view.OrderState = orderState;
            _view.Date = date;
            _view.Price = price;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var productsNames = unit.Products.GetAllNames();
                _view.Products.DataSource = productsNames;
                _view.Products.Text = productName;
                var clientsNames = unit.Clients.GetAllNames();
                _view.Clients.DataSource = clientsNames;
                _view.Clients.Text = clientFullName;
                var discountsNames = unit.Discounts.GetAllNames();
                _view.Discounts.DataSource = discountsNames;
                _view.Discounts.Text = discountName;
            }
        }

        public void InitUpdateForm(string productName, string clientFullName, string discountName, ProductOrder order)
        {
            _view.ProductQuantity = order.ProductOrderQuantity;
            _view.PaymentType = order.PaymentType;
            _view.OrderState = order.OrderState;
            _view.Date = order.ProductOrderDate;
            _view.Price = order.ProductOrderPrice;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var productsNames = unit.Products.GetAllNames();
                _view.Products.DataSource = productsNames;
                _view.Products.Text = productName;
                var clientsNames = unit.Clients.GetAllNames();
                _view.Clients.DataSource = clientsNames;
                _view.Clients.Text = clientFullName;
                var discountsNames = unit.Discounts.GetAllNames();
                _view.Discounts.DataSource = discountsNames;
                _view.Discounts.Text = discountName;
            }
        }

        private void OnUpdateButtonClick()
        {
            _productOrder = new ProductOrder();
            _productOrder.ProductOrderQuantity = _view.ProductQuantity;
            _productOrder.ProductOrderPrice = _view.Price;
            _productOrder.ProductOrderDate = _view.Date;
            _productOrder.OrderState = _view.OrderState;
            _productOrder.PaymentType = _view.PaymentType;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Client c = unit.Clients.Find(x => x.ClientFullName.Equals(_view.Clients.Text)).Single();
                _productOrder.Client = c;
                _productOrder.ClientId = c.ClientId;
                Product p = unit.Products.Find(x => x.ProductName.Equals(_view.Products.SelectedValue)).Single();
                _productOrder.Product = p;
                _productOrder.ProductId = p.ProductId;
                Discount d = unit.Discounts.Find(x => x.DiscountName.Equals(_view.Discounts.SelectedValue)).Single();
                _productOrder.Discount = d;
                _productOrder.DiscountId = d.DiscountId;
            }
        }

        private void OnCancelButtonClick()
        {
            _productOrder = null;
        }
    }
}