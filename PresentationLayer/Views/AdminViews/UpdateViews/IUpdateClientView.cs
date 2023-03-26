using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateClientView
    {
        string Username { get; set; }
        Label UsernameError { get; set; }
        string Password { get; set; }
        //Label PasswordError { get; set; }
        string FullName { get; set; }
        Label FullNameError { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        Label EmailError { get; set; }
        bool CorrectInfo { get; set; }

        event Action UpdateData;
        event Action Cancel;

        void ShowView();
    }
}