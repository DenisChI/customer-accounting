using System;
using System.Collections.Generic;
using PresentationLayer.Views.AdminViews;

namespace PresentationLayer.Presenters.AdminPresenters
{
    public class SelectDatesPresenter : ISelectDatesPresenter
    {
        private ISelectDatesView _view;

        public SelectDatesPresenter(ISelectDatesView view)
        {
            _view = view;
            _view.Confirm += OnConfirmButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public ISelectDatesView GetSelectDatesView() { return _view; }

        private void OnConfirmButtonClick()
        {
            _view.StartDate = _view.StartDate.Date;
            _view.EndDate = _view.EndDate.Date;
        }

        private void OnCancelButtonClick()
        {
            DateTime minValue = new DateTime(1753, 1, 1);
            _view.StartDate = minValue;
            _view.EndDate = minValue;
        }

    }
}
