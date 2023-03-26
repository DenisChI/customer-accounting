using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;
using PresentationLayer.Views.AdminViews;
using PresentationLayer.Presenters.AdminPresenters;
using PresentationLayer.Presenters.AdminPresenters.InsertPresenters;
using PresentationLayer.Presenters.AdminPresenters.UpdatePresenters;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    public class AdminPresenter
    {
        private IAdminMainView _adminMainView;
        //insert
        private IInsertClientPresenter _inputClientPresenter;
        private IInsertDiscountPresenter _inputDiscountPresenter;
        private IInsertProductAtStockPresenter _inputProductAtStockPresenter;
        private IInsertProductOrderPresenter _inputProductOrderPresenter;
        private IInsertProductPresenter _inputProductPresenter;
        private IInsertProviderPresenter _inputProviderPresenter;
        private IInsertWarehousePresenter _inputWarehousePresenter;
        private ISelectDatesPresenter _selectDatesPresenter;
        //update
        private IUpdateClientPresenter _updateClientPresenter;
        private IUpdateDiscountPresenter _updateDiscountPresenter;
        private IUpdateProductAtStockPresenter _updateProductAtStockPresenter;
        private IUpdateProductOrderPresenter _updateProductOrderPresenter;
        private IUpdateProductPresenter _updateProductPresenter;
        private IUpdateProviderPresenter _updateProviderPresenter;
        private IUpdateWarehousePresenter _updateWarehousePresenter;

        public IAdminMainView GetAdminView() { return _adminMainView; }
        public AdminPresenter(
            IAdminMainView view,
            IInsertClientPresenter insertClientPresenter,
            IInsertDiscountPresenter insertDiscountPresenter,
            IInsertProductAtStockPresenter insertProductAtStockPresenter,
            IInsertProductOrderPresenter insertProductOrderPresenter,
            IInsertProductPresenter insertProductPresenter,
            IInsertProviderPresenter insertProviderPresenter,
            IInsertWarehousePresenter insertWarehousePresenter,
            ISelectDatesPresenter selectDatesPresenter,
            IUpdateClientPresenter updateClientPresenter,
            IUpdateDiscountPresenter updateDiscountPresenter,
            IUpdateProductAtStockPresenter updateProductAtStockPresenter,
            IUpdateProductOrderPresenter updateProductOrderPresenter,
            IUpdateProductPresenter updateProductPresenter,
            IUpdateProviderPresenter updateProviderPresenter,
            IUpdateWarehousePresenter updateWarehousePresenter
            )
        {
            //insert
            _adminMainView = view;
            _inputClientPresenter = insertClientPresenter;
            _inputDiscountPresenter = insertDiscountPresenter;
            _inputProductAtStockPresenter = insertProductAtStockPresenter;
            _inputProductOrderPresenter = insertProductOrderPresenter;
            _inputProductPresenter = insertProductPresenter;
            _inputProviderPresenter = insertProviderPresenter;
            _inputWarehousePresenter = insertWarehousePresenter;
            _selectDatesPresenter = selectDatesPresenter;
            //update
            _updateClientPresenter = updateClientPresenter;
            _updateDiscountPresenter = updateDiscountPresenter;
            _updateProductAtStockPresenter = updateProductAtStockPresenter;
            _updateProductOrderPresenter = updateProductOrderPresenter;
            _updateProductPresenter = updateProductPresenter;
            _updateProviderPresenter = updateProviderPresenter;
            _updateWarehousePresenter = updateWarehousePresenter;

            _adminMainView.ClientButtonClick += OnClientButtonClick;
            _adminMainView.ProductAtStockButtonClick += OnProductAtStockButtonClick;
            _adminMainView.ProductButtonClick += OnProductButtonClick;
            _adminMainView.ProviderButtonClick += OnProviderButtonClick;
            _adminMainView.WarehouseButtonClick += OnWarehouseButtonClick;
            _adminMainView.ProductOrderButtonClick += OnProductOrderButtonClick;
            _adminMainView.DiscountButtonClick += OnDiscountButtonClick;
            _adminMainView.AddRow += OnAddOption;
            _adminMainView.UpdateRow += OnUpdateOption;
            _adminMainView.DeleteRow += OnDeleteOption;
            _adminMainView.SelectReport += OnWatchReportButtonClick;
        }

        private void OnWatchReportButtonClick()
        {
            switch (_adminMainView.Report.SelectedIndex)
            {
                case 0:
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            var orders = unit.ProductOrders.GetOrdersAboveAveragePrice();
                            _adminMainView.CurrentTableName = "ProductOrder";
                            _adminMainView.InitializeDataGridView();
                            string paymentType;
                            string orderState;
                            foreach (ProductOrder pO in orders)
                            {
                                if (pO.PaymentType.Equals("CASH"))
                                {
                                    paymentType = "Наличными";
                                }
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
                                else orderState = "Завершён";
                                _adminMainView.Table.Rows.Add(
                                    pO.ProductOrderId,
                                    unit.Products.Get(pO.ProductId).ProductName,
                                    unit.Clients.Get(pO.ClientId).ClientFullName,
                                    pO.ProductOrderQuantity,
                                    paymentType,
                                    orderState,
                                    unit.Discounts.Get(pO.DiscountId).DiscountName,
                                    pO.ProductOrderDate,
                                    pO.ProductOrderPrice);
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        _selectDatesPresenter.GetSelectDatesView().ShowInputDataView();
                        DateTime startDate = _selectDatesPresenter.GetSelectDatesView().StartDate;
                        DateTime endDate = _selectDatesPresenter.GetSelectDatesView().EndDate;
                        if (startDate == endDate) //равны только тогда, когда, была нажата кнопка "Отмена"
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                var orders = unit.ProductOrders.GetAllOrdersBetweenDates(startDate, endDate);
                                if (orders.Count() > 0)
                                {
                                    _adminMainView.CurrentTableName = "ProductOrder";
                                    _adminMainView.InitializeDataGridView();
                                    string paymentType;
                                    string orderState;
                                    foreach (ProductOrder pO in orders)
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
                                        else orderState = "Завершён";
                                        _adminMainView.Table.Rows.Add(pO.ProductOrderId,
                                            unit.Products.Get(pO.ProductId).ProductName, unit.Clients.Get(pO.ClientId).ClientFullName,
                                            pO.ProductOrderQuantity, paymentType, orderState, unit.
                                            Discounts.Get(pO.DiscountId).DiscountName, pO.ProductOrderDate.ToString("d"), pO.ProductOrderPrice);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Нет заказов за указанный период.");
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            var expensiveOrders = unit.ProductOrders.GetTheMostExpensiveOrdersForEachClient().OrderBy(x => x.ProductOrderPrice);
                            _adminMainView.CurrentTableName = "ProductOrder";
                            _adminMainView.InitializeDataGridView();
                            string paymentType;
                            string orderState;
                            foreach (ProductOrder pO in expensiveOrders)
                            {
                                if (pO.PaymentType.Equals("CASH"))
                                {
                                    paymentType = "Наличными";
                                }
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
                                else orderState = "Завершён";
                                _adminMainView.Table.Rows.Add(
                                    pO.ProductOrderId,
                                    unit.Products.Get(pO.ProductId).ProductName,
                                    unit.Clients.Get(pO.ClientId).ClientFullName,
                                    pO.ProductOrderQuantity,
                                    paymentType,
                                    orderState,
                                    unit.Discounts.Get(pO.DiscountId).DiscountName,
                                    pO.ProductOrderDate.ToString("d"),
                                    pO.ProductOrderPrice);
                            }
                        }
                    }
                    break;
            }
        }

        private void OnDeleteOption()
        {
            int id = (int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value;
            switch (_adminMainView.CurrentTableName)
            {
                case "Client":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.Clients.Remove(id);
                            unit.Complete();
                        }
                        OnClientButtonClick();
                    }
                    break;
                case "Product":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.Products.Remove(id);
                            unit.Complete();
                        }
                        OnProductButtonClick();
                    }
                    break;
                case "Provider":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.Providers.Remove(id);
                            unit.Complete();
                        }
                        OnProviderButtonClick();
                    }
                    break;
                case "Warehouse":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.Warehouses.Remove(id);
                            unit.Complete();
                        }
                        OnWarehouseButtonClick();
                    }
                    break;
                case "ProductAtStock":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.ProductAtStocks.Remove(id);
                            unit.Complete();
                        }
                        OnProductAtStockButtonClick();
                    }
                    break;
                case "ProductOrder":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.ProductOrders.Remove(id);
                            unit.Complete();
                        }
                        OnProductOrderButtonClick();
                    }
                    break;
                case "Discount":
                    {
                        using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                        {
                            unit.Discounts.Remove(id);
                            unit.Complete();
                        }
                        OnDiscountButtonClick();
                    }
                    break;
            }
        }

        private void OnUpdateOption()
        {
            switch (_adminMainView.CurrentTableName)
            {
                case "Client":
                    {
                        Client cl = new Client();
                        cl.ClientUsername = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value;
                        cl.ClientPassword = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value;
                        cl.ClientFullName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[3].Value;
                        cl.ClientPhoneNumber = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[4].Value;
                        string address = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[5].Value;
                        cl.ClientEmail = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[6].Value;
                        _updateClientPresenter.InitUpdateForm(cl, address);
                        _updateClientPresenter.GetView().ShowView();
                        Client editedClient = _updateClientPresenter.GetClient();
                        if (editedClient != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                Client oldClient = unit.Clients.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                oldClient.ClientUsername = editedClient.ClientUsername;
                                oldClient.ClientPassword = editedClient.ClientPassword;
                                oldClient.ClientFullName = editedClient.ClientFullName;
                                oldClient.ClientPhoneNumber = editedClient.ClientPhoneNumber;
                                oldClient.ClientEmail = editedClient.ClientEmail;
                                oldClient.Address = editedClient.Address;
                                oldClient.AddressId = editedClient.AddressId;
                                unit.Clients.Update(oldClient);
                                unit.Complete();
                            }
                            OnClientButtonClick();
                        }
                    }
                    break;
                case "Product":
                    {
                        _updateProductPresenter.InitUpdateForm(
                            (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value,
                            (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value,
                            (float)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[3].Value);
                        _updateProductPresenter.GetView().ShowView();
                        Product editedProduct = _updateProductPresenter.GetProduct();
                        if (editedProduct != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                Product oldProduct = unit.Products.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                oldProduct.ProductName = editedProduct.ProductName;
                                oldProduct.Provider = editedProduct.Provider;
                                oldProduct.ProductSellingPrice = editedProduct.ProductSellingPrice;
                                unit.Products.Update(oldProduct);
                                unit.Complete();
                            }
                            OnProductButtonClick();
                        }
                    }
                    break;
                case "Provider":
                    {
                        Provider provider = new Provider();
                        provider.ProviderCompanyName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value;
                        provider.ProviderPhoneNumber = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value;
                        provider.ProviderEmail = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[4].Value;
                        string address = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[3].Value;
                        _updateProviderPresenter.InitUpdateForm(provider, address);
                        _updateProviderPresenter.GetView().ShowView();
                        Provider edited = _updateProviderPresenter.GetProvider();
                        if (edited != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                Provider old = unit.Providers.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                old.ProviderCompanyName = edited.ProviderCompanyName;
                                old.ProviderPhoneNumber = edited.ProviderPhoneNumber;
                                old.Address = edited.Address;
                                old.AddressId = edited.AddressId;
                                old.ProviderEmail = edited.ProviderEmail;
                                unit.Providers.Update(old);
                                unit.Complete();
                            }
                            OnProviderButtonClick();
                        }
                    }
                    break;
                case "Warehouse":
                    {
                        Warehouse w = new Warehouse();
                        w.WarehouseName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value;
                        w.WarehouserFullname = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value;
                        _updateWarehousePresenter.InitUpdateForm(w);
                        _updateWarehousePresenter.GetView().ShowView();
                        Warehouse edited = _updateWarehousePresenter.GetWarehouse();
                        if (edited != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                Warehouse old = unit.Warehouses.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                old.WarehouseName = edited.WarehouseName;
                                old.WarehouserFullname = edited.WarehouserFullname;
                                unit.Warehouses.Update(old);
                                unit.Complete();
                            }
                            OnWarehouseButtonClick();
                        }
                    }
                    break;
                case "ProductAtStock":
                    {
                        _updateProductAtStockPresenter.InitUpdateForm(
                            (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value,
                            (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value,
                            (int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[3].Value,
                            Convert.ToDateTime(_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[4].Value));
                        _updateProductAtStockPresenter.GetView().ShowView();
                        ProductAtStock edited = _updateProductAtStockPresenter.GetProductAtStock();
                        if (edited != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                ProductAtStock old = unit.ProductAtStocks.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                old.Product = edited.Product;
                                old.Warehouse = edited.Warehouse;
                                old.ProductAtStockQuantity = edited.ProductAtStockQuantity;
                                old.ProductAtStockDate = edited.ProductAtStockDate;
                                unit.ProductAtStocks.Update(old);
                                unit.Complete();
                            }
                            OnProductAtStockButtonClick();
                        }
                    }
                    break;
                case "ProductOrder":
                    {
                        string productName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value;
                        string clientFullName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value;
                        string discountName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[6].Value;
                        ProductOrder order = new ProductOrder();
                        order.ProductOrderQuantity = (int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[3].Value;
                        order.PaymentType = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[4].Value;
                        order.OrderState = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[5].Value;
                        order.ProductOrderDate = Convert.ToDateTime(_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[7].Value);
                        order.ProductOrderPrice = (decimal)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[8].Value;
                        _updateProductOrderPresenter.InitUpdateForm(productName, clientFullName, discountName, order);
                        _updateProductOrderPresenter.GetView().ShowView();
                        ProductOrder edited = _updateProductOrderPresenter.GetProductOrder();
                        if (edited != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                ProductOrder old = unit.ProductOrders.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                old.Product = edited.Product;
                                old.Client = edited.Client;
                                old.ProductOrderQuantity = edited.ProductOrderQuantity;
                                old.PaymentType = edited.PaymentType;
                                old.OrderState = edited.OrderState;
                                old.Discount = edited.Discount;
                                old.ProductOrderDate = edited.ProductOrderDate;
                                old.ProductOrderPrice = edited.ProductOrderPrice;
                                unit.ProductOrders.Update(old);
                                unit.Complete();
                            }
                            OnProductOrderButtonClick();
                        }
                    }
                    break;
                case "Discount":
                    {
                        Discount d = new Discount();
                        d.DiscountName = (string)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[1].Value;
                        d.DiscountPerecentage = (float)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[2].Value;
                        _updateDiscountPresenter.InitUpdateForm(d);
                        _updateDiscountPresenter.GetView().ShowView();
                        Discount edited = _updateDiscountPresenter.GetDiscount();
                        if (edited != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                Discount old = unit.Discounts.Get((int)_adminMainView.Table.Rows[_adminMainView.RowIndex].Cells[0].Value);
                                old.DiscountName = edited.DiscountName;
                                old.DiscountPerecentage = edited.DiscountPerecentage;
                                unit.Discounts.Update(old);
                                unit.Complete();
                            }
                            OnDiscountButtonClick();
                        }
                    }
                    break;
            }
        }

        private void OnAddOption()
        {
            switch (_adminMainView.CurrentTableName)
            {
                case "Client":
                    {
                        _inputClientPresenter.InitAddForm();
                        _inputClientPresenter.GetInsertView().ShowInputDataView();
                        Client client = _inputClientPresenter.GetClient();
                        if (client != null)
                        {
                            OnClientButtonClick();
                        }
                    }
                    break;
                case "Product":
                    {
                        _inputProductPresenter.InitAddForm();
                        _inputProductPresenter.GetInsertView().ShowInsertView();
                        Product product = _inputProductPresenter.GetProduct();
                        if (product != null)
                        {
                            OnProductButtonClick();
                        }
                    }
                    break;
                case "Provider":
                    {
                        _inputProviderPresenter.InitAddForm();
                        _inputProviderPresenter.GetInsertView().ShowInsertView();
                        Provider p = _inputProviderPresenter.GetProvider();
                        if (p != null)
                        {
                            OnProviderButtonClick();
                        }
                    }
                    break;
                case "Warehouse":
                    {
                        _inputWarehousePresenter.InitAddForm();
                        _inputWarehousePresenter.GetInsertView().ShowInputDataView();
                        Warehouse warehouse = _inputWarehousePresenter.GetWarehouse();
                        if (warehouse != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                unit.Warehouses.Add(warehouse);
                                unit.Complete();
                            }
                            OnWarehouseButtonClick();
                        }
                    }
                    break;
                case "ProductAtStock":
                    {
                        _inputProductAtStockPresenter.InitAddForm();
                        _inputProductAtStockPresenter.GetInsertView().ShowInsertView();
                        ProductAtStock pAS = _inputProductAtStockPresenter.GetProductAtStock();
                        if (pAS != null)
                        {
                            OnProductAtStockButtonClick();
                        }
                    }
                    break;
                case "ProductOrder":
                    {
                        _inputProductOrderPresenter.InitAddForm();
                        _inputProductOrderPresenter.GetInsertView().ShowInsertView();
                        ProductOrder pO = _inputProductOrderPresenter.GetProductOrder();
                        if (pO != null)
                        {
                            OnProductOrderButtonClick();
                        }
                    }
                    break;
                case "Discount":
                    {
                        _inputDiscountPresenter.InitAddForm();
                        _inputDiscountPresenter.GetInsertView().ShowInsertView();
                        Discount d = _inputDiscountPresenter.GetDiscount();
                        if (d != null)
                        {
                            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                            {
                                unit.Discounts.Add(d);
                                unit.Complete();
                            }
                            OnDiscountButtonClick();
                        }
                    }
                    break;
            }
        }

        private void OnDiscountButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Discounts.GetAll().OrderBy(x => x.DiscountPerecentage);
                foreach (Discount d in list)
                {
                    _adminMainView.Table.Rows.Add(d.DiscountId, d.DiscountName, d.DiscountPerecentage);
                }
            }
        }

        private void OnProductOrderButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.ProductOrders.GetAll().OrderBy(x => x.ProductOrderId);
                string paymentType;
                string orderState;
                foreach (ProductOrder pO in list)
                {
                    if (pO.PaymentType.Equals("CASH"))
                    {
                        paymentType = "Наличными";
                    }
                    else
                    {
                        paymentType = "Картой";
                    }

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
                        orderState = "Завершён";
                    }

                    _adminMainView.Table.Rows.Add(
                        pO.ProductOrderId,
                        unit.Products.Get(pO.ProductId).ProductName,
                        unit.Clients.Get(pO.ClientId).ClientFullName,
                        pO.ProductOrderQuantity,
                        paymentType,
                        orderState,
                        unit.Discounts.Get(pO.DiscountId).DiscountName,
                        pO.ProductOrderDate.ToString("d"),
                        pO.ProductOrderPrice);
                }
            }

        }

        private void OnWarehouseButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Warehouses.GetAll().OrderBy(x => x.WarehouseId);
                foreach (Warehouse w in list)
                {
                    _adminMainView.Table.Rows.Add(w.WarehouseId, w.WarehouseName, w.WarehouserFullname);
                }
            }
        }

        private void OnProviderButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Providers.GetAll().OrderBy(x => x.ProviderId);
                Address address;
                string addressInfo;
                foreach (Provider p in list)
                {
                    address = unit.Addresses.Get(p.AddressId);
                    if (address == null)
                        addressInfo = "Нет";
                    else
                        addressInfo = address.AddressInfo;
                    {
                        _adminMainView.Table.Rows.Add(p.ProviderId, p.ProviderCompanyName, p.ProviderPhoneNumber,
                                                      addressInfo, p.ProviderEmail);
                    }
                }
            }
        }

        private void OnProductButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Products.GetAll().OrderBy(x => x.ProductId);
                foreach (Product p in list)
                {
                    _adminMainView.Table.Rows.Add(p.ProductId, p.ProductName,
                        unit.Providers.Get(p.ProviderId).ProviderCompanyName,
                        p.ProductSellingPrice);
                }
            }
        }

        private void OnProductAtStockButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.ProductAtStocks.GetAll().OrderBy(x => x.ProductAtStockId);
                foreach (ProductAtStock p in list)
                {
                    _adminMainView.Table.Rows.Add(
                        p.ProductAtStockId,
                        unit.Products.Get(p.ProductId).ProductName,
                        unit.Warehouses.Get(p.WarehouseId).WarehouseName,
                        p.ProductAtStockQuantity,
                        p.ProductAtStockDate.ToString("d"));
                }
            }
        }

        private void OnClientButtonClick()
        {
            _adminMainView.InitializeDataGridView();
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var list = unit.Clients.GetAll().OrderBy(x => x.ClientId);
                Address address;
                string addressInfo;
                foreach (Client c in list)
                {
                    address = unit.Addresses.Get(c.AddressId);
                    if (address == null)
                        addressInfo = string.Empty;
                    else
                        addressInfo = address.AddressInfo;
                    _adminMainView.Table.Rows.Add(c.ClientId, c.ClientUsername, 
                                                  c.ClientPassword, c.ClientFullName, 
                                                  c.ClientPhoneNumber, addressInfo, c.ClientEmail);
                }
            }
        }
    }
}