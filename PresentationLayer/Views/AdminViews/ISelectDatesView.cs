using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews
{
    public interface ISelectDatesView
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        event Action Confirm;
        event Action Cancel;

        void ShowInputDataView();
    }
}