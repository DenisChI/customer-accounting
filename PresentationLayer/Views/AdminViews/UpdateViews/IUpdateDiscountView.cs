using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public interface IUpdateDiscountView
    {
        string DiscountName { get; set; }
        Label DiscountNameError { get; set; }
        float DiscountPercentage  { get; set; }
        bool CorrectInfo { get; set; }

        event Action Cancel;
        event Action UpdateData;

        void ShowView();
    }
}