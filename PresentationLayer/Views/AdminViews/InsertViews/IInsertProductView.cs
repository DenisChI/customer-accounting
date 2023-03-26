using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertProductView
    {
        string ProductNaming { get; set; }
        Label ProductNamingError { get; set; }
        ComboBox ProviderName { get; set; }
        float SellingPrice { get; set; }
        bool CorrectInfo { get; set; }

        event Action AddData;
        event Action Cancel;
        void ShowInsertView();
    }
}