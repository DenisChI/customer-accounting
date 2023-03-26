using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public partial class InsertWarehouseView : Form, IInsertWarehouseView
    {
        public string WarehouseName { get { return textBoxWarehouseName.Text; } set { textBoxWarehouseName.Text = value; } }
        public Label WarehouseNameError { get { return labelWarehouseNameError; } set { labelWarehouseNameError = value; } }
        public Label WarehouserFullNameError { get { return labelWarehouserFullNameError; } set { labelWarehouserFullNameError = value; } }
        public string WarehouserFullName { get { return textBoxWarehouserFullName.Text; } set { textBoxWarehouserFullName.Text = value; } }
        public bool CorrectInfo { get; set; }

        public event Action AddData;
        public event Action Cancel;
        public InsertWarehouseView()
        {
            InitializeComponent();
        }

        private bool IsWarehouseNameEmpty()
        {
            WarehouseName = WarehouseName.Trim();
            if (WarehouseName.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private bool IsWarehouserFulltNameEmpty()
        {
            WarehouserFullName = WarehouserFullName.Trim();
            if (WarehouserFullName.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private bool IsAnyTextBoxEmpty()
        {
            bool warehouseNameEmpty = IsWarehouseNameEmpty();
            bool warehousersFullNameEmpty = IsWarehouserFulltNameEmpty();
            if (warehouseNameEmpty && warehousersFullNameEmpty)
            {
                labelWarehouseNameError.ForeColor = System.Drawing.Color.Red;
                labelWarehouseNameError.Text = "Нужно заполнить название склада";
                labelWarehouseNameError.Visible = true;
                labelWarehouserFullNameError.ForeColor = System.Drawing.Color.Red;
                labelWarehouserFullNameError.Text = "Нужно заполнить ФИО кладовщика";
                labelWarehouserFullNameError.Visible = true;
                return true;
            }
            else if (warehouseNameEmpty)
            {
                labelWarehouserFullNameError.Text = string.Empty;
                labelWarehouseNameError.Visible = false;
                labelWarehouseNameError.ForeColor = System.Drawing.Color.Red;
                labelWarehouseNameError.Text = "Нужно заполнить название склада";
                labelWarehouseNameError.Visible = true;
                return true;
            }
            else if (warehousersFullNameEmpty)
            {
                labelWarehouseNameError.Text = string.Empty;
                labelWarehouseNameError.Visible = false;
                labelWarehouserFullNameError.ForeColor = System.Drawing.Color.Red;
                labelWarehouserFullNameError.Text = "Нужно заполнить ФИО кладовщика";
                labelWarehouserFullNameError.Visible = true;
                return true;
            }
            else
            {
                labelWarehouseNameError.Text = string.Empty;
                labelWarehouseNameError.Visible = false;
                labelWarehouserFullNameError.Text = string.Empty;
                labelWarehouserFullNameError.Visible = false;
                return false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!IsAnyTextBoxEmpty())
            {
                AddData?.Invoke();
                CorrectInfo = true;
                if (CorrectInfo)
                    Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void ShowInputDataView()
        {
            this.ShowDialog();
        }

        private void textBoxWarehouserFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}