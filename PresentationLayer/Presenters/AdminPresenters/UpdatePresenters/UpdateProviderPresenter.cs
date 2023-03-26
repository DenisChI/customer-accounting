using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    public class UpdateProviderPresenter : IUpdateProviderPresenter
    {
        private IUpdateProviderView _view;
        private Provider _provider;
        private string _oldName;
        private string _oldEmail;
        public UpdateProviderPresenter(IUpdateProviderView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCancelButtonClick;
        }

        public IUpdateProviderView GetView() { return _view; }
        public Provider GetProvider() { return _provider; }

        public void InitUpdateForm(string companyName, string phoneNumber, string address, string email)
        {
            _view.CompanyNaming = companyName;
            _view.PhoneNumber = phoneNumber;
            _view.Address = address;
            _view.Email = email;
            _view.CompanyNameError.Visible = false;
            _view.EmailError.Visible = false;
            _view.CompanyNameError.Text = string.Empty;
            _view.EmailError.Text = string.Empty;
            _oldName = companyName;
            _oldEmail = email;
        }

        public void InitUpdateForm(Provider provider, string address)
        {
            _view.CompanyNaming = provider.ProviderCompanyName;
            _view.PhoneNumber = provider.ProviderPhoneNumber;
            _view.Email = provider.ProviderEmail;
            _view.Address = address;
            _view.CompanyNameError.Visible = false;
            _view.EmailError.Visible = false;
            _view.CompanyNameError.Text = string.Empty;
            _view.EmailError.Text = string.Empty;
            _oldName = provider.ProviderCompanyName;
            _oldEmail = provider.ProviderEmail;
        }

        private void OnUpdateButtonClick()
        {
            List<string> names;
            List<string> emails;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                names = unit.Providers.GetAllNames().ToList();
                emails = unit.Providers.GetAllEmails().ToList();
            }
            _provider = new Provider();
            if (!_oldName.Equals(_view.CompanyNaming) && names.Contains(_view.CompanyNaming))
            {
                _view.CompanyNameError.Text = "Поставщик с таким названием\nуже существует";
                _view.CompanyNameError.ForeColor = System.Drawing.Color.Red;
                _view.CompanyNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (!_oldEmail.Equals(_view.Email) && emails.Contains(_view.Email))
            {
                _view.EmailError.Text = "Поставщик с такой почтой уже существует";
                _view.CompanyNameError.ForeColor = System.Drawing.Color.Red;
                _view.CompanyNameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (_view.CorrectInfo)
            {
                _provider.ProviderCompanyName = _view.CompanyNaming;
                _provider.ProviderEmail = _view.Email;
                _provider.ProviderPhoneNumber = _view.PhoneNumber;
                _view.CorrectInfo = true;
                if (!_view.Address.Equals(string.Empty))
                {
                    using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                    {
                        Address address = unit.Addresses.GetByInfo(_view.Address);
                        if (address == null)
                        {
                            _provider.Address = new Address();
                            _provider.Address.AddressInfo = _view.Address;
                        }
                        else
                        {
                            _provider.Address = address;
                            _provider.AddressId = address.AddressId;
                        }
                    }
                }
                else
                {
                    _provider.AddressId = null;
                }
            }
        }

        private void OnCancelButtonClick()
        {
            _provider = null;
        }
    }
}