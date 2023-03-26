using System;
using DomainLayer.Models;
using PresentationLayer.Views.AdminViews.UpdateViews;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public interface IUpdateProductAtStockPresenter
    {
        ProductAtStock GetProductAtStock();
        IUpdateProductAtStockView GetView();
        void InitUpdateForm(string productNameing, string warehouseName, int quantity, DateTime date);
    }
}