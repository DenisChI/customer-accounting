using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertWarehouseView
    {
        string WarehouseName { get; set; }
        string WarehouserFullName { get; set; }
        Label WarehouseNameError { get; set; }
        Label WarehouserFullNameError { get; set; }
        bool CorrectInfo { get; set; }

        event Action AddData;
        event Action Cancel;
        void ShowInputDataView();
    }
}