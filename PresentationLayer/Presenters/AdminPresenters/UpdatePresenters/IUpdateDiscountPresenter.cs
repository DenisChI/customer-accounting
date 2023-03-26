using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateDiscountPresenter
    {
        Discount GetDiscount();
        IUpdateDiscountView GetView();
        void InitUpdateForm(string discountName, float discountPercent);
        void InitUpdateForm(Discount discount);
    }
}