using System;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public interface IInsertProductAtStockPresenter
    {
        IInsertProductAtStockView GetInsertView();
        ProductAtStock GetProductAtStock();
        void InitAddForm();
    }
}