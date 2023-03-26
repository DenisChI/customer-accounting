using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdateProductAtStockView : Form, IUpdateProductAtStockView
    {
        public ComboBox ProductNaming { get { return comboBoxProductName; } set { comboBoxProductName = value; } }
        public ComboBox WarehouseName { get { return comboBoxWarehouseName; } set { comboBoxWarehouseName = value; } }
        public int Quantity { get { return (int)numericUpDownQuantity.Value; } set { numericUpDownQuantity.Value = value; } }
        public DateTime Date { get { return dateTimePicker.Value; } set { dateTimePicker.Value = value; } }

        public event Action UpdateData;
        public event Action Cancel;

        public UpdateProductAtStockView()
        {
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData?.Invoke();
            //this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void ShowView()
        {
            this.ShowDialog();
        }
    }
}