using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateClientPresenter
    {
        IUpdateClientView GetView();
        Client GetClient();
        void InitUpdateForm(string fullName, string phoneNumber, string address, string email);
        void InitUpdateForm(Client client, string address);
    }
}