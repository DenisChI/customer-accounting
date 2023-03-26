using System;
using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateDiscountPresenter : IUpdateDiscountPresenter
    {
        private IUpdateDiscountView _view;
        private Discount _discount;
        private string _oldName;

        public UpdateDiscountPresenter(IUpdateDiscountView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateDiscountView GetView() { return _view; }
        public Discount GetDiscount() { return _discount; }

        public void InitUpdateForm(string discountName, float discountPercent)
        {
            _view.DiscountName = discountName;
            _view.DiscountPercentage  = discountPercent;
            _view.DiscountNameError.Visible = false;
            _oldName = discountName; //для последующего сравнения
        }

        public void InitUpdateForm(Discount discount) 
        {
            _view.DiscountName = discount.DiscountName;
            _view.DiscountPercentage = discount.DiscountPerecentage;
            _view.DiscountNameError.Visible = false;
            _oldName = discount.DiscountName; //для последующего сравнения
        }

        private void OnUpdateButtonClick()
        {
            List<string> names;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                names = unit.Discounts.GetAllNames().ToList();
            }
            if (!_view.DiscountName.Equals(_oldName) && names.Contains(_view.DiscountName))
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
                _discount.DiscountPerecentage = _view.DiscountPercentage ;
                _view.CorrectInfo = true;
            }
        }

        private void OnCancelButtonClick()
        {
            _discount = null;
        }
    }
}