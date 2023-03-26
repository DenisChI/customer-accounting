﻿using System;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdateProviderView : Form, IUpdateProviderView
    {
        public string CompanyNaming { get { return textBoxCompanyName.Text; } set { textBoxCompanyName.Text = value; } }
        public Label CompanyNameError { get { return labelCompanyNameError; } set { labelCompanyNameError = value; } }
        public string PhoneNumber { get; set; }
        public string Address { get { return textBoxAddress.Text; } set { textBoxAddress.Text = value; } }
        public string Email { get { return textBoxEmail.Text; } set { textBoxEmail.Text = value; } }
        public Label EmailError { get { return labelEmailError; } set { labelEmailError = value; } }
        public bool CorrectInfo { get; set; }

        public event Action UpdateData;
        public event Action Cancel;

        public UpdateProviderView()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            if (!PhoneNumber.Equals(string.Empty))
                maskedTextBoxPhoneNumber.Text = PhoneNumber.Substring(1);
        }

        private bool IsCompanyNamingEmpty()
        {
            CompanyNaming = CompanyNaming.Trim();
            if (CompanyNaming.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private bool IsValidEmail()
        {
            try
            {
                Email = new MailAddress(textBoxEmail.Text.Trim()).Address;
                labelEmailError.Text = string.Empty;
                labelEmailError.Visible = false;
                return true;
            }
            catch (FormatException)
            {
                labelEmailError.Text = "Неправильный адрес электронной почты!";
                labelEmailError.ForeColor = Color.Red;
                labelEmailError.Visible = true;
                return false;
            }
            catch (ArgumentException)
            {
                labelEmailError.Text = "Адрес электронной почты\nдолжен быть заполнен!";
                labelEmailError.ForeColor = Color.Red;
                labelEmailError.Visible = true;
                return false;
            }
        }

        private void TransformPhoneNumber()
        {
            string pattern = @"\D";
            string target = string.Empty;
            Regex regex = new Regex(pattern);
            PhoneNumber = regex.Replace(maskedTextBoxPhoneNumber.Text, target);
            if (PhoneNumber.Length == 1)
                PhoneNumber = string.Empty;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!IsCompanyNamingEmpty())
            {
                labelCompanyNameError.Text = string.Empty;
                labelCompanyNameError.Visible = false;
                if (IsValidEmail())
                {
                    TransformPhoneNumber();
                    UpdateData?.Invoke();
                    CorrectInfo = true;
                    if (CorrectInfo)
                        Close();
                }
            }
            else
            {
                labelCompanyNameError.Text = "Нужно заполнить название компании";
                labelCompanyNameError.ForeColor = Color.Red;
                labelCompanyNameError.Visible = true;
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
            InitForm();
            this.ShowDialog();
        }
    }
}