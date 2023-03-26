using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertProviderPresenter : IInsertProviderPresenter
    {
        private IInsertProviderView _view;
        private Provider _provider;
        public InsertProviderPresenter(IInsertProviderView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IInsertProviderView GetInsertView() { return _view; }
        public Provider GetProvider() { return _provider; }

        public void InitAddForm()
        {
            _view.CompanyNaming = string.Empty;
            _view.PhoneNumber = string.Empty;
            _view.Address = string.Empty;
            _view.Email = string.Empty;
            _view.CompanyNameError.Visible = false;
            _view.EmailError.Visible = false;
        }

        private void OnAddButtonClick()
        {
            List<string> names;
            List<string> emails;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                names = unit.Providers.GetAllNames().ToList();
                emails = unit.Providers.GetAllEmails().ToList();
            }
            if (names.Contains(_view.CompanyNaming))
            {
                _view.CompanyNameError.Text = "Поставщик с таким названием\nуже существует";
                _view.CompanyNameError.ForeColor = System.Drawing.Color.Red;
                _view.CompanyNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (emails.Contains(_view.Email))
            {
                _view.EmailError.Text = "Поставщик с такой почтой уже существует";
                _view.CompanyNameError.ForeColor = System.Drawing.Color.Red;
                _view.CompanyNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (_view.CorrectInfo)
            {
                _provider = new Provider();
                _provider.ProviderCompanyName = _view.CompanyNaming;
                _provider.ProviderEmail = _view.Email;
                _provider.ProviderPhoneNumber = _view.PhoneNumber;
                using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                {
                    if (_view.Address.Equals(string.Empty))
                    {
                        unit.Providers.Add(_provider);
                        unit.Complete();
                        return;
                    }
                    Address address = unit.Addresses.GetByInfo(_view.Address);
                    if (address == null)
                    {
                        address = new Address();
                        address.AddressInfo = _view.Address;
                        unit.Addresses.Add(address);
                        unit.Complete();
                        address = unit.Addresses.GetByInfo(_view.Address);
                        address.Providers.Add(_provider);
                        unit.Complete();
                        return;
                    }
                    else
                    {
                        address.Providers.Add(_provider);
                        unit.Complete();
                    }
                }
            }
        }

        private void OnCancelButtonClick()
        {
            _provider = null;
        }
    }
}