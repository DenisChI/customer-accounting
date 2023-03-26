using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public partial class InsertProductAtStockView : Form, IInsertProductAtStockView
    {
        public ComboBox ProductNaming { get { return comboBoxProductName; } set { comboBoxProductName = value; } }
        public ComboBox WarehouseName { get { return comboBoxWarehouseName; } set { comboBoxWarehouseName = value; } }
        public int Quantity { get { return (int)numericUpDownQuantity.Value; } set { numericUpDownQuantity.Value = value; } }
        public DateTime Date { get { return dateTimePicker.Value; } set { dateTimePicker.Value = value; } }

        public event Action AddData;
        public event Action Cancel;

        public InsertProductAtStockView()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddData?.Invoke();
            //this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void ShowInsertView()
        {
            this.ShowDialog();
        }
    }
}