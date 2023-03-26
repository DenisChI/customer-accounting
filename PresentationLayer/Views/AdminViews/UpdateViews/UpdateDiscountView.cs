using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdataDataDiscountView : Form, IUpdateDiscountView
    {
        public string DiscountName { get { return textBoxDiscountName.Text; } set { textBoxDiscountName.Text = value; } }
        public Label DiscountNameError { get { return labelDiscountNameError; } set { labelDiscountNameError = value; } }
        public float DiscountPercentage { get { return float.Parse(numericUpDownPercentage.Text); } set { numericUpDownPercentage.Text = value.ToString(); } }
        public bool CorrectInfo { get; set; }
        public event Action UpdateData;
        public event Action Cancel;

        public UpdataDataDiscountView()
        {
            InitializeComponent();
        }

        private bool IsDiscountNameEmpty()
        {
            DiscountName = DiscountName.Trim();
            if (DiscountName.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsDiscountNameEmpty())
            {
                labelDiscountNameError.Text = string.Empty;
                labelDiscountNameError.Visible = false;
                UpdateData?.Invoke();
                CorrectInfo = true;
                if (CorrectInfo)
                    Close();
            }
            else
            {
                labelDiscountNameError.Text = "Нужно заполнить название скидки";
                labelDiscountNameError.ForeColor = Color.Red;
                labelDiscountNameError.Visible = true;
            }
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