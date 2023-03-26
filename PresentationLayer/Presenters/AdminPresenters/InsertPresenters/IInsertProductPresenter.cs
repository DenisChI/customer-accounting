using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertProductPresenter
    {
        IInsertProductView GetInsertView();
        Product GetProduct();
        void InitAddForm();
    }
}