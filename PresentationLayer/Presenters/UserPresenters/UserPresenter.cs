using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;
using PresentationLayer.Views.UserViews;


namespace PresentationLayer.Presenters.UserPresenters
{
    public class UserPresenter
    {
        private IUserMainView _view;
        private Client _client;

        public UserPresenter(IUserMainView view, Client client)
        {
            _view = view;
            _client = client;
            _view.ShowReport += OnShowReportButtonClick;
        }

        public IUserMainView GetUserView() { return _view; }
        private void OnShowReportButtonClick()
        {
            switch(_view.Report.SelectedIndex)
            {
                case 0:
                    ShowProductOrderTable();
                    break;
                case 1:
                    ShowProductTable();
                    break;
                case 2:
                    ShowProviderTable();
                    break;
                case 3:
                    ShowDiscountTable();
                    break;
                case 4:
                    ShowProductAtStockTable();
                    break;
            }
        }

        private void ShowProductOrderTable()
        {
            _view.InitializeDataGridView("ProductOrder");
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.ProductOrders.GetProductOrdersByCliendId(_client.ClientId).OrderBy(x => x.ProductOrderId);
                string paymentType;
                string orderState;
                foreach (ProductOrder pO in list)
                {
                    if (pO.PaymentType.Equals("CASH"))
                        paymentType = "Наличными";
                    else
                        paymentType = "Картой";
                    if (pO.OrderState.Equals("APPROVED"))
                    {
                        orderState = "Подтверждён";
                    }
                    else if (pO.OrderState.Equals("RETURNED"))
                    {
                        orderState = "Возвращён";
                    }
                    else if (pO.OrderState.Equals("DELIVERY"))
                    {
                        orderState = "В процессе доставки";
                    }
                    else
                    {
                        orderState = "Завершён"; //Завершён
                    }
                    _view.Table.Rows.Add(
                        pO.ProductOrderId,
                        unit.Products.Get(pO.ProductId).ProductName,
                        pO.ProductOrderQuantity,
                        paymentType,
                        orderState,
                        unit.Discounts.Get(pO.DiscountId).DiscountName,
                        pO.ProductOrderDate.ToString("d"),
                        pO.ProductOrderPrice);
                }
            }
        }

        private void ShowProductTable()
        {
            _view.InitializeDataGridView("Product");
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Products.GetAll().OrderBy(x => x.ProductId);
                foreach (Product p in list)
                {
                    _view.Table.Rows.Add(
                        p.ProductId,
                        p.ProductName,
                        unit.Providers.Get(p.ProviderId).ProviderCompanyName,
                        p.ProductSellingPrice);
                }
            }
        }

        private void ShowProviderTable()
        {
            _view.InitializeDataGridView("Provider");
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Providers.GetAll().OrderBy(x => x.ProviderId);
                foreach (Provider p in list)
                {
                    _view.Table.Rows.Add(
                        p.ProviderId,
                        p.ProviderCompanyName,
                        p.ProviderPhoneNumber,
                        unit.Addresses.Get(p.AddressId).AddressInfo,
                        p.ProviderEmail);
                }
            }
        }

        private void ShowProductAtStockTable()
        {
            _view.InitializeDataGridView("ProductAtStock");
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.ProductAtStocks.GetAll().OrderBy(x => x.ProductAtStockId);
                foreach (ProductAtStock p in list)
                {
                    _view.Table.Rows.Add(
                        p.ProductAtStockId,
                        unit.Products.Get(p.ProductId).ProductName,
                        unit.Warehouses.Get(p.WarehouseId).WarehouseName,
                        p.ProductAtStockQuantity,
                        p.ProductAtStockDate.ToString("d")
                       );
                }
            }
        }

        private void ShowDiscountTable()
        {
            _view.InitializeDataGridView("Discount");
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Discounts.GetAll().OrderBy(x => x.DiscountPerecentage);
                foreach (Discount d in list)
                {
                    _view.Table.Rows.Add(d.DiscountId, d.DiscountName, d.DiscountPerecentage);
                }
            }
        }
    }
}