using System;
using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertDiscountPresenter : IInsertDiscountPresenter
    {
        private IInsertDiscountView _view;
        private Discount _discount;

        public InsertDiscountPresenter(IInsertDiscountView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertDiscountView GetInsertView() { return _view; }
        public Discount GetDiscount() { return _discount; }
        public void InitAddForm()
        {
            _view.DiscountName = string.Empty;
            _view.DiscountPercentage = 0;
            _view.DiscountNameError.Visible = false;
        }

        private void OnAddButtonClick()
        {
            List<string> names;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                names = unit.Discounts.GetAllNames().ToList();
            }
            if (names.Contains(_view.DiscountName))
            {
                _view.DiscountNameError.Text = "Скидка с таким названием уже есть";
                _view.DiscountNameError.ForeColor = System.Drawing.Color.Red;
                _view.DiscountNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            else
            {
                _discount = new Discount();
                _discount.DiscountName = _view.DiscountName;
                _discount.DiscountPerecentage = _view.DiscountPercentage;
                _view.CorrectInfo = true;
            }
        }

        private void OnCancelButtonClick()
        {
            _discount = null;
        }
    }
}