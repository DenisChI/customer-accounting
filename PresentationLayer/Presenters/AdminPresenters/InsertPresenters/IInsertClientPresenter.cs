using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.InsertViews;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertClientPresenter
    {
        IInsertClientView GetInsertView();
        Client GetClient();
        void InitAddForm();
    }
}