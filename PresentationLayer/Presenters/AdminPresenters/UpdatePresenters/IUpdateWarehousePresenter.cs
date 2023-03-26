using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateWarehousePresenter
    {
        IUpdateWarehouseView GetView();
        Warehouse GetWarehouse();
        void InitUpdateForm(string warehouseName, string warehouserFullName);
        void InitUpdateForm(Warehouse warehouse);
    }
}