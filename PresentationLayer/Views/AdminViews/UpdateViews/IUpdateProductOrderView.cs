using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateProductOrderView
    {
        ComboBox Clients { get; set; }
        DateTime Date { get; set; }
        ComboBox Discounts { get; set; }
        string OrderState { get; set; }
        string PaymentType { get; set; }
        decimal Price { get; set; }
        int ProductQuantity { get; set; }
        ComboBox Products { get; set; }

        event Action UpdateData;
        event Action Cancel;

        void InitForm();
        void ShowView();
    }
}