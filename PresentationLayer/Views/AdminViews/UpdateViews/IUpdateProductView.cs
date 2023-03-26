using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateProductView
    {
        string ProductNaming { get; set; }
        Label ProductNamingError { get; set; }
        ComboBox ProviderName { get; set; }
        float SellingPrice { get; set; }
        bool CorrectInfo { get; set; }

        event Action Cancel;
        event Action UpdateData;

        void ShowView();
    }
}