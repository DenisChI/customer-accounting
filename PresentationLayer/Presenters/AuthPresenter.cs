using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using ServiceLayer.Services.UnitOfWorkServices;
using PresentationLayer.Views;
using PresentationLayer.Views.AdminViews;
using PresentationLayer.Views.AdminViews.InsertViews;
using PresentationLayer.Views.AdminViews.UpdateViews;
using PresentationLayer.Views.UserViews;
using PresentationLayer.Presenters.AdminPresenters;
using PresentationLayer.Presenters.AdminPresenters.InsertPresenters;
using PresentationLayer.Presenters.AdminPresenters.UpdatePresenters;
using PresentationLayer.Presenters.UserPresenters;

namespace PresentationLayer.Presenters
{
    public class AuthPresenter
    {
        IAuthView _authView;

        public IAuthView GetAuthView() { return _authView; }

        public AuthPresenter(IAuthView authView)
        {
            _authView = authView;
            _authView.Auth += OnButtonAuthclick;
        }

        private void OnButtonAuthclick()
        {
            if (_authView.Username.Equals("admin") && _authView.Password.Equals("admin"))
            {
                ShowAdminMainView();
            }
            else
            {
                Client client;
                //int id = -1;
                using (UnitOfWork unit = new UnitOfWork(new CustomerAccountingContext()))
                {
                    try
                    {
                        client = unit.Clients.Get(_authView.Username, _authView.Password);
                        //id = client.ClientId;
                        ShowUserView(client);
                    }
                    catch (InvalidOperationException)
                    {
                        _authView.UsernameError.Text = "";
                        _authView.PasswordError.Text = "Не верный логин или пароль!";
                        _authView.PasswordError.Visible = true;
                        _authView.PasswordError.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        private void ShowAdminMainView()
        {
            //Presenters
            var inputClientP = new InsertClientPresenter(new InsertClientView());
            var inputDiscountP = new InsertDiscountPresenter(new InsertDiscountView());
            var inputProductP = new InsertProductPresenter(new InsertProductView());
            var inputProductOrderP = new InsertProductOrderPresenter(new InsertProductOrderView());
            var inputProductAtStockP = new InsertProductAtStockPresenter(new InsertProductAtStockView());
            var inputProviderP = new InsertProviderPresenter(new InsertProviderView());
            var inputWarehouseP = new InsertWarehousePresenter(new InsertWarehouseView());
            var selectDatesP = new SelectDatesPresenter(new SelectDatesView());
            var updateClientP = new UpdateClientPresenter(new UpdateClientView());
            var updateDiscountP = new UpdateDiscountPresenter(new UpdataDataDiscountView());
            var updateProductP = new UpdateProductPresenter(new UpdateProductView());
            var updateProductOrderP = new UpdateProductOrderPresenter(new UpdateProductOrderView());
            var updateProductAtStockP = new UpdateProductAtStockPresenter(new UpdateProductAtStockView());
            var updateProviderP = new UpdateProviderPresenter(new UpdateProviderView());
            var updateWarehouseP = new UpdateWarehousePresenter(new UpdateWarehouseView());

            var adminMainPresenter = new AdminPresenter(new AdminMainView(),
                inputClientP, inputDiscountP, inputProductAtStockP, inputProductOrderP, inputProductP, inputProviderP, inputWarehouseP, selectDatesP,
                updateClientP, updateDiscountP, updateProductAtStockP, updateProductOrderP, updateProductP, updateProviderP, updateWarehouseP);
            IAdminMainView adminView = adminMainPresenter.GetAdminView();
            //adminMainView.FormClosed += (object s, FormClosedEventArgs ev) =>
            //{
            //    this.Show();
            //    this.Close();
            //};
            _authView.HideView();
            adminView.ShowView();
        }

        private void ShowUserView(Client client)
        {
            var userPresenter = new UserPresenter(new UserMainView(client.ClientUsername), client);
            var userV = userPresenter.GetUserView();
            _authView.HideView();
            userV.ShowView();
        }
    }
}