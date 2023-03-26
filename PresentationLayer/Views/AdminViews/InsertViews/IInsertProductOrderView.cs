using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertProductOrderView
    {
        ComboBox Products { get; set; }
        ComboBox Clients { get; set; }
        ComboBox Discounts { get; set; }
        DateTime Date { get; set; }
        string OrderState { get; set; }
        string PaymentType { get; set; }
        decimal Price { get; set; }
        int ProductQuantity { get; set; }

        event Action AddData;
        event Action Cancel;
        void ShowInsertView();
    }
}