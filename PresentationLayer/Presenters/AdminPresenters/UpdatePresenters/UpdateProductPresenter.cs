using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateProductPresenter : IUpdateProductPresenter
    {
        private IUpdateProductView _view;
        private Product _product;
        private string _oldProductName;

        public UpdateProductPresenter(IUpdateProductView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateProductView GetView() { return _view; }
        public Product GetProduct() { return _product; }

        public void InitUpdateForm(string productName, string providerName, float price)
        {
            _view.ProductNaming = productName;
            _view.SellingPrice = price;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                var providersNames = unit.Providers.GetAllNames();
                _view.ProviderName.DataSource = providersNames;
                _view.ProviderName.Text = providerName;
            }
            _oldProductName = productName;
        }

        private void OnUpdateButtonClick()
        {
            //List<string> names;
            //using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            //{
            //names = unit.Products.GetAllNames().ToList();
            //}
            //if(_view.ProductNaming.Equals(_oldProductName))
            //{
            _product = new Product();
            _product.ProductName = _view.ProductNaming;
            _product.ProductSellingPrice = _view.SellingPrice;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                Provider p = unit.Providers.Find(x => x.ProviderCompanyName.Equals(_view.ProviderName.SelectedValue)).Single();
                _product.ProviderId = p.ProviderId;
                _product.Provider = p;
                //p.Products.Add(_product);
                //unit.Providers.Update(p);
                //unit.Complete();
            }
            //_view.CorrectInfo = true;
            //}
            //else if (names.Contains(_view.ProductNaming))
            //{
            //_view.ProductNamingError.Text = "Продукт с таким названием уже есть";
            //_view.ProductNamingError.ForeColor = System.Drawing.Color.Red;
            //_view.ProductNamingError.Visible = true;
            //_view.DialogResult = System.Windows.Forms.DialogResult.None;
            //}
        }

        private void OnCancelButtonClick()
        {
            _product = null;
        }
    }
}