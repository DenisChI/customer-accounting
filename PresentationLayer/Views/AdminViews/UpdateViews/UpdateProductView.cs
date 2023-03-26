using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdateProductView : Form, IUpdateProductView
    {
        public string ProductNaming { get { return textBoxProductName.Text; } set { textBoxProductName.Text = value; } }
        public Label ProductNamingError { get { return labelProductNameError; } set { labelProductNameError = value; } }
        public ComboBox ProviderName { get { return comboBoxProviderName; } set { comboBoxProviderName = value; } }
        public float SellingPrice { get { return float.Parse(numericUpDownSellingPrice.Text); } set { numericUpDownSellingPrice.Text = value.ToString(); } }
        public bool CorrectInfo { get; set; }
        public event Action UpdateData;
        public event Action Cancel;

        public UpdateProductView()
        {
            InitializeComponent();
        }

        private bool IsProductNamingEmpty()
        {
            ProductNaming = ProductNaming.Trim();
            if (ProductNaming.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsProductNamingEmpty())
            {
                labelProductNameError.Text = string.Empty;
                labelProductNameError.Visible = false;
                UpdateData?.Invoke();
                CorrectInfo = true;
                if (CorrectInfo)
                    Close();
            }
            else
            {
                labelProductNameError.Text = "Нужно заполнить название товара";
                labelProductNameError.ForeColor = Color.Red;
                labelProductNameError.Visible = true;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel; //мб убрать
            Close();
        }

        public void ShowView()
        {
            this.ShowDialog();
        }
    }
}