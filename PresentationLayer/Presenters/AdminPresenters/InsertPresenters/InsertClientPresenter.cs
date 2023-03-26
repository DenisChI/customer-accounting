using System;
using System.Collections.Generic;
using System.Linq;
using PresentationLayer.Views.AdminViews.InsertViews;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;

namespace PresentationLayer.Presenters.AdminPresenters.InsertPresenters
{
    public class InsertClientPresenter : IInsertClientPresenter
    {
        private IInsertClientView _view;
        private Client _client;

        public InsertClientPresenter(IInsertClientView view)
        {
            _view = view;
            _view.AddData += OnAddButtonClick;
            _view.Cancel += OnCacncelButtonClick;
        }

        public IInsertClientView GetInsertView() { return _view; }
        public Client GetClient() { return _client; }
        public void InitAddForm()
        {
            _view.Username = string.Empty;
            _view.Password = string.Empty;
            _view.FullName = string.Empty;
            _view.PhoneNumber = string.Empty;
            _view.Address = string.Empty;
            _view.Email = string.Empty;
            _view.UsernameError.Visible = false;
            _view.FullNameError.Visible = false;
            _view.EmailError.Visible = false;
        }

        private void OnAddButtonClick()
        {
            List<string> usernames;
            List<string> emails;
            using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
            {
                usernames = unit.Clients.GetAllUsernames().ToList();
                emails = unit.Clients.GetAllEmails().ToList();
            }
            if (usernames.Contains(_view.Username))
            {
                _view.UsernameError.Text = "Такой пользователь уже существует";
                _view.UsernameError.ForeColor = System.Drawing.Color.Red;
                _view.UsernameError.Visible = true;
                _view.CorrectInfo = false;
            }
            if (emails.Contains(_view.Email))
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
                using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                {
                    if (_view.Address.Equals(string.Empty))
                    {
                        unit.Clients.Add(_client);
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
                        address.Clients.Add(_client);
                        unit.Complete();
                        return;
                    }
                    else
                    {
                        address.Clients.Add(_client);
                        unit.Complete();
                    }
                }
            }
        }

        private void OnCacncelButtonClick()
        {
            _client = null;
        }

    }
}