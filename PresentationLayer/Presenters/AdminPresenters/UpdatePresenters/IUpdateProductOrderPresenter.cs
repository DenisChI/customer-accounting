using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;
using System;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateProductOrderPresenter
    {
        ProductOrder GetProductOrder();
        IUpdateProductOrderView GetView();
        void InitUpdateForm(string productName, string clientFullName, int quantity, string paymentType, string orderState, string discountName, DateTime date, decimal price);
        void InitUpdateForm(string productName, string clientFullName, string discountName, ProductOrder order);
    }
}