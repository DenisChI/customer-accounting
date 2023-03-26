using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertWarehousePresenter
    {
        IInsertWarehouseView GetInsertView();
        Warehouse GetWarehouse();
        void InitAddForm();
    }
}