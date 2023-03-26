using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public interface IAuthView
    {
        string Username { get; set; }
        string Password { get; set; }
        Label UsernameError { get; set; }
        Label PasswordError { get; set; }
        event Action Auth;
        void ShowAuthView();
        void HideView();
    }
}