using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertDiscountPresenter
    {
        IInsertDiscountView GetInsertView();
        Discount GetDiscount();
        void InitAddForm();
    }
}