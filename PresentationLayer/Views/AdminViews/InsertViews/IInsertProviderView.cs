using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertProviderView
    {
        string CompanyNaming { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        Label CompanyNameError { get; set; }
        Label EmailError { get; set; }
        bool CorrectInfo { get; set; }
        event Action AddData;
        event Action Cancel;
        void ShowInsertView();
    }
}