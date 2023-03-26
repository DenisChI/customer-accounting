using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.InsertViews
{
    public partial class InsertProductView : Form, IInsertProductView
    {
        public string ProductNaming { get { return textBoxProductName.Text; } set { textBoxProductName.Text = value; } }
        public Label ProductNamingError { get { return labelProductNamingError; } set { labelProductNamingError = value; } }
        public ComboBox ProviderName { get { return comboBoxProviderName; } set { comboBoxProviderName = value; } }
        public float SellingPrice { get { return float.Parse(numericUpDownSellingPrice.Text); } set { numericUpDownSellingPrice.Text = value.ToString(); } }
        public bool CorrectInfo { get; set; }

        public event Action AddData;
        public event Action Cancel;

        public InsertProductView()
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!IsProductNamingEmpty())
            {
                labelProductNamingError.Text = string.Empty;
                labelProductNamingError.Visible = false;
                AddData?.Invoke();
                CorrectInfo = true;
                if (CorrectInfo)
                    Close();
            }
            else
            {
                labelProductNamingError.Text = "Нужно заполнить название товара";
                labelProductNamingError.ForeColor = Color.Red;
                labelProductNamingError.Visible = true;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel; //мб убрать
            Close();
        }

        public void ShowInsertView()
        {
            this.ShowDialog();
        }
    }
}