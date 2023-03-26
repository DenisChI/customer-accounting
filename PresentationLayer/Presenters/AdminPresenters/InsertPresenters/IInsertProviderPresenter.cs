using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertProviderPresenter
    {
        IInsertProviderView GetInsertView();
        Provider GetProvider();
        void InitAddForm();
    }
}