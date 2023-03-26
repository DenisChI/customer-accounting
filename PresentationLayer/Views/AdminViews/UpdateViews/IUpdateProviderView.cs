using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateProviderView
    {
        string Address { get; set; }
        Label CompanyNameError { get; set; }
        string CompanyNaming { get; set; }
        string Email { get; set; }
        Label EmailError { get; set; }
        string PhoneNumber { get; set; }
        bool CorrectInfo { get; set; }
        event Action Cancel;
        event Action UpdateData;

        void ShowView();
    }
}