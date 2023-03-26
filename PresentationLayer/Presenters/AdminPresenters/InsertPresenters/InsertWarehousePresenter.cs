using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertWarehousePresenter : IInsertWarehousePresenter
    {
        private IInsertWarehouseView _view;
        private Warehouse _warehouse;

        public InsertWarehousePresenter(IInsertWarehouseView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertWarehouseView GetInsertView() { return _view; }
        public Warehouse GetWarehouse()
        {
            return _warehouse;
        }
        public void InitAddForm()
        {
            _view.WarehouseName = string.Empty;
            _view.WarehouserFullName = string.Empty;
            _view.WarehouseNameError.Visible = false;
            _view.WarehouserFullNameError.Visible = false;
        }
        private void OnAddButtonClick()
        {
            List<string> warehousesNames;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                warehousesNames = unit.Warehouses.GetAllWarehousesNames().ToList();
            }
            if (warehousesNames.Contains(_view.WarehouseName))
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
                _view.CorrectInfo = true;
            }
        }

        private void OnCancelButtonClick()
        {
            _warehouse = null;
        }
    }
}