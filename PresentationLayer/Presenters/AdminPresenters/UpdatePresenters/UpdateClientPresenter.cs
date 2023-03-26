using System;
using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.UpdateViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.UpdatePresenters
{
    class UpdateClientPresenter : IUpdateClientPresenter
    {
        private IUpdateClientView _view;
        private Client _client;
        private string _oldUsername;
        private string _oldEmail;

        public UpdateClientPresenter(IUpdateClientView view)
        {
            _view = view;
            _view.UpdateData += OnUpdateButtonClick;
            _view.Cancel += OnCacncelButtonClick;
        }
        public IUpdateClientView GetView() { return _view; }
        public Client GetClient() { return _client; }

        public void InitUpdateForm(string fullName, string phoneNumber, string address, string email)
        {
            _view.FullName = fullName;
            _view.PhoneNumber = phoneNumber;
            _view.Address = address;
            _view.Email = email;
            _view.FullNameError.Visible = false;
            _view.EmailError.Visible = false;
            _oldEmail = email;
        }

        public void InitUpdateForm(Client client, string address)
        {
            _view.Username = client.ClientUsername;
            _view.Password = client.ClientPassword;
            _view.FullName = client.ClientFullName;
            _view.PhoneNumber = client.ClientPhoneNumber;
            _view.Email = client.ClientEmail;
            _view.Address = address;
            _view.FullNameError.Visible = false;
            _view.EmailError.Visible = false;
            _oldEmail = client.ClientEmail;
            _oldUsername = client.ClientUsername;
        }

        private void OnUpdateButtonClick()
        {
            List<string> usernames;
            List<string> emails;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                usernames = unit.Clients.GetAllUsernames().ToList();
                emails = unit.Clients.GetAllEmails().ToList();
            }
            if (!usernames.Contains(_oldUsername) && usernames.Contains(_view.Username))
            {
                _view.UsernameError.Text = "Такой пользователь уже существует";
                _view.UsernameError.ForeColor = System.Drawing.Color.Red;
                _view.UsernameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (!_view.Email.Equals(_oldEmail) && emails.Contains(_view.Email))
            {
                _view.EmailError.Text = "Такая почта уже существует";
                _view.EmailError.ForeColor = System.Drawing.Color.Red;
                _view.EmailError.Visible = true;
                _view.CorrectInfo = false;
            }
            if(_view.CorrectInfo)
            {
                _client = new Client();
                _client.ClientUsername = _view.Username;
                _client.ClientPassword = _view.Password;
                _client.ClientFullName = _view.FullName;
                _client.ClientPhoneNumber = _view.PhoneNumber;
                _client.ClientEmail = _view.Email;
                if (!_view.Address.Equals(string.Empty))
                {
                    using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                    {
                        Address address = unit.Addresses.GetByInfo(_view.Address);
                        if (address == null)
                        {
                            _client.Address = new Address();
                            _client.Address.AddressInfo = _view.Address;
                        }
                        else
                        {
                            _client.Address = address;
                            _client.AddressId = address.AddressId;
                        }
                    }
                }
                else
                {
                    _client.AddressId = null;
                }
            }
        }

        private void OnCacncelButtonClick()
        {
            _client = null;
        }
    }
}