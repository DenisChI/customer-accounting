using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.UserViews
{
    public interface IUserMainView
    {
        ComboBox Report { get; set; }
        DataGridView Table { get; set; }
        event Action ShowReport;
        void InitializeDataGridView(string tableName);
        void ShowView();
    }
}