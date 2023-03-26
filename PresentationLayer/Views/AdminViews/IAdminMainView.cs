using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews
{
    public interface IAdminMainView
    {
        DataGridView Table { get; set; }
        int RowIndex { get; set; }
        ComboBox Report { get; set; }
        string CurrentTableName { get; set; }
        event Action ClientButtonClick;
        event Action DiscountButtonClick;
        event Action ProductAtStockButtonClick;
        event Action ProductButtonClick;
        event Action ProductOrderButtonClick;
        event Action ProviderButtonClick;
        event Action WarehouseButtonClick;
        event Action AddRow;
        event Action UpdateRow;
        event Action DeleteRow;
        event Action SelectReport;
        void InitializeDataGridView();
        void ShowView();
    }
}