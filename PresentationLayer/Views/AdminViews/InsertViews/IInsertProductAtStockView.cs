using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertProductAtStockView
    {
        ComboBox ProductNaming { get; set; }
        ComboBox WarehouseName { get; set; }
        int Quantity { get; set; }
        DateTime Date { get; set; }
        event Action AddData;
        event Action Cancel;
        void ShowInsertView();
    }
}