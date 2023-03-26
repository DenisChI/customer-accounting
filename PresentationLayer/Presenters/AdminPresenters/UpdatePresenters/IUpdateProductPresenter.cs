using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateProductPresenter
    {
        Product GetProduct();
        IUpdateProductView GetView();
        void InitUpdateForm(string productName, string providerName, float price);
    }
}