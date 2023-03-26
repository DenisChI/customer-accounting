using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateWarehouseView
    {
        string WarehouseName { get; set; }
        Label WarehouseNameError { get; set; }
        string WarehouserFullName { get; set; }
        Label WarehouserFullNameError { get; set; }
        bool CorrectInfo { get; set; }
        event Action UpdateData;
        event Action Cancel;

        void ShowView();
    }
}