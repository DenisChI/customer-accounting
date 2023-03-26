using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateProviderPresenter
    {
        Provider GetProvider();
        IUpdateProviderView GetView();
        void InitUpdateForm(string companyName, string phoneNumber, string address, string email);
        void InitUpdateForm(Provider provider, string address);
    }
}