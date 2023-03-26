using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateWarehousePresenter : IUpdateWarehousePresenter
    {
        private IUpdateWarehouseView _view;
        private Warehouse _warehouse;
        private string _oldWarehouseName;

        public UpdateWarehousePresenter(IUpdateWarehouseView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateWarehouseView GetView() { return _view; }
        public Warehouse GetWarehouse() { return _warehouse; }

        public void InitUpdateForm(string warehouseName, string warehouserFullName)
        {
            _view.WarehouseName = warehouseName;
            _view.WarehouserFullName = warehouserFullName;
            _oldWarehouseName = warehouseName;
            _view.WarehouseNameError.Visible = false;
            _view.WarehouserFullNameError.Visible = false;
        }

        public void InitUpdateForm(Warehouse warehouse)
        {
            _view.WarehouseName = warehouse.WarehouseName;
            _view.WarehouserFullName = warehouse.WarehouserFullname;
            _oldWarehouseName = warehouse.WarehouseName;
            _view.WarehouseNameError.Visible = false;
            _view.WarehouserFullNameError.Visible = false;
        }

        private void OnUpdateButtonClick()
        {
            List<string> warehousesNames;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                warehousesNames = unit.Warehouses.GetAllWarehousesNames().ToList();
            }
            if (!_view.WarehouseName.Equals(_oldWarehouseName) && warehousesNames.Contains(_view.WarehouseName))
            {
                _view.WarehouseNameError.Text = "Склад с таким названием уже есть";
                _view.WarehouseNameError.ForeColor = System.Drawing.Color.Red;
                _view.WarehouseNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            else
            {
                _warehouse = new Warehouse();
                _warehouse.WarehouseName = _view.WarehouseName;
                _warehouse.WarehouserFullname = _view.WarehouserFullName;
            }
        }

        private void OnCancelButtonClick()
        {
            _warehouse = null;
        }
    }
}