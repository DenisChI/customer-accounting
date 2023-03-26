using System;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertProductOrderPresenter
    {
        IInsertProductOrderView GetInsertView();
        ProductOrder GetProductOrder();
        void InitAddForm();
    }
}