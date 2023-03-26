using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateProductAtStockView
    {
        DateTime Date { get; set; }
        ComboBox ProductNaming { get; set; }
        int Quantity { get; set; }
        ComboBox WarehouseName { get; set; }

        event Action Cancel;
        event Action UpdateData;

        void ShowView();
    }
}