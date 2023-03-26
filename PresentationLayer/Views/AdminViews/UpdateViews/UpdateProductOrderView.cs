using System;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdateProductOrderView : Form, IUpdateProductOrderView
    {
        public ComboBox Products { get { return comboBoxProductName; } set { comboBoxProductName = value; } }
        public ComboBox Clients { get { return comboBoxClientFullName; } set { comboBoxClientFullName = value; } }
        public ComboBox Discounts { get { return comboBoxDiscounts; } set { comboBoxDiscounts = value; } }
        public int ProductQuantity { get { return (int)numericUpDownProductQuantity.Value; } set { numericUpDownProductQuantity.Value = value; } }
        public string PaymentType { get; set; }
        public string OrderState { get; set; }
        public DateTime Date { get { return dateTimePicker.Value; } set { dateTimePicker.Value = value; } }
        public decimal Price { get { return numericUpDownPrice.Value; } set { numericUpDownPrice.Value = value; } }

        public event Action UpdateData;
        public event Action Cancel;
        public UpdateProductOrderView()
        {
            InitializeComponent();
        }

        public void InitForm()
        {
            comboBoxPaymentType.Text = PaymentType;
            comboBoxOrderState.Text = OrderState;
        }

        private void FormatPaymentType()
        {
            if (comboBoxPaymentType.Text.Equals("Картой"))
                PaymentType = "CARD";
            else
                PaymentType = "CASH";
        }

        private void FormatOrderState()
        {
            if (comboBoxOrderState.Text.Equals("Подтверждён"))
            {
                OrderState = "APPROVED";
            }
            else if (comboBoxOrderState.Text.Equals("Возвращён"))
            {
                OrderState = "RETURNED";
            }
            else if (comboBoxOrderState.Text.Equals("В процессе доставки"))
            {
                OrderState = "DELIVERY";
            }
            else
            {
                OrderState = "COMPLETED"; //Завершён
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            FormatPaymentType();
            FormatOrderState();
            UpdateData?.Invoke();
            //this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            //this.DialogResult = DialogResult.Cancel; //мб убрать
            Close();
        }

        public void ShowView()
        {
            InitForm();
            this.ShowDialog();
        }
    }
}