using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertProductPresenter : IInsertProductPresenter
    {
        private IInsertProductView _view;
        private Product _product;
        public InsertProductPresenter(IInsertProductView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertProductView GetInsertView() { return _view; }
        public Product GetProduct() { return _product; }
        private void OnAddButtonClick()
        {
            //List<string> names;
            //using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            //{
            //    names = unit.Products.GetAllNames().ToList();
            //}
            //if (names.Contains(_inputDataProductView.ProductNaming))
            //{
            //    _inputDataProductView.ProductNamingError.Text = "Продукт с таким названием уже есть";
            //    _inputDataProductView.ProductNamingError.ForeColor = System.Drawing.Color.Red;
            //    _inputDataProductView.ProductNamingError.Visible = true;
            //    _view.DialogResult = System.Windows.Forms.DialogResult.None;
            //}
            //else
            //{
            _product = new Product();
            _product.ProductName = _view.ProductNaming;
            _product.ProductSellingPrice = _view.SellingPrice;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Provider p = unit.Providers.Find(x => x.ProviderCompanyName.Equals(_view.ProviderName.SelectedValue)).Single();
                p.Products.Add(_product);
                unit.Complete();
            }
            //}
        }

        public void InitAddForm()
        {
            _view.ProductNaming = string.Empty;
            _view.SellingPrice = 0;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var providersNames = unit.Providers.GetAllNames();
                _view.ProviderName.DataSource = providersNames;
            }
        }

        private void OnCancelButtonClick()
        {
            _product = null;
        }
    }
}