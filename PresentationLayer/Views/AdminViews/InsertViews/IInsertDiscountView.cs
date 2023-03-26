using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public interface IInsertDiscountView
    {
        string DiscountName { get; set; }
        Label DiscountNameError { get; set; }
        float DiscountPercentage { get; set; }
        bool CorrectInfo { get; set; }
        event Action AddData;
        event Action Cancel;
        void ShowInsertView();
    }
}