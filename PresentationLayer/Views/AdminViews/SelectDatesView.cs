using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews
{
    public partial class SelectDatesView : Form, ISelectDatesView
    {
        public SelectDatesView()
        {
            InitializeComponent();
        }

        public DateTime StartDate { get { return dateTimePickerStartDate.Value; } set { dateTimePickerStartDate.Value = value; } }
        public DateTime EndDate { get { return dateTimePickerEndDate.Value; } set { dateTimePickerEndDate.Value = value; } }
        public event Action Confirm;
        public event Action Cancel;

        private bool IsDatesValid()
        {
            bool valid = false;
            if (StartDate < EndDate)
                valid = true;
            return valid;
        }
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (IsDatesValid())
            {
                Confirm?.Invoke();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, "Начало периода должно быть раньше конца периода!", "Ошибка при выборе периода времени", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void ShowInputDataView()
        {
            this.ShowDialog();
        }
    }
}