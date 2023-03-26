using System;
using PresentationLayer.Views.AdminViews;

namespace PresentationLayer.Presenters.AdminPresenters
{
    public interface ISelectDatesPresenter
    {
        ISelectDatesView GetSelectDatesView();
    }
}