using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationLayer.Views.AdminViews.UpdateViews
{
    public partial class UpdateClientView : Form, IUpdateClientView
    {
        public string Username { get { return textBoxUsername.Text; } set { textBoxUsername.Text = value; } }
        public Label UsernameError { get { return labelUsernameErr; } set { labelUsernameErr = value; } }
        public string Password { get { return textBoxPassword.Text; } set { textBoxPassword.Text = value; } }
        public Label PasswordError { get { return labelPasswordErr; } set { labelPasswordErr = value; } }
        public string FullName { get { return textBoxFullName.Text; } set { textBoxFullName.Text = value; } }
        public Label FullNameError { get { return labelFullNameErr; } set { labelFullNameErr = value; } }
        public string PhoneNumber { get; set; }
        public string Address { get { return textBoxAddress.Text; } set { textBoxAddress.Text = value; } }
        public string Email { get { return textBoxEmail.Text; } set { textBoxEmail.Text = value; } }
        public Label EmailError { get { return labelEmailError; } set { labelEmailError = value; } }
        public bool CorrectInfo { get; set; }
        public event Action UpdateData;
        public event Action Cancel;

        public UpdateClientView()
        {
            InitializeComponent();
            labelFullNameErr.Visible = false;
            labelEmailError.Visible = false;
        }

        public void InitForm()
        {
            if (!PhoneNumber.Equals(string.Empty))
                maskedTextBoxPhoneNumber.Text = PhoneNumber.Substring(1);
        }

        private bool IsUsernameLengthValid()
        {
            Username = Username.Trim();
            if (Username.Length < 2)
                return false;
            else
                return true;
        }

        private bool IsPasswordLengthValid()
        {
            Password = Password.Trim();
            if (Password.Length < 5)
                return false;
            else
                return true;
        }

        private bool CheckUsernameAndPassword()
        {
            bool usernameLengthValid = IsUsernameLengthValid();
            bool passwordLengthValid = IsPasswordLengthValid();
            if (!usernameLengthValid && !passwordLengthValid)
            {
                labelUsernameErr.ForeColor = System.Drawing.Color.Red;
                labelUsernameErr.Visible = true;
                labelUsernameErr.Text = "Логин должен иметь длину\nот 2 до 15 символов!";
                labelPasswordErr.ForeColor = System.Drawing.Color.Red;
                labelPasswordErr.Visible = true;
                labelPasswordErr.Text = "Пароль должен иметь длину\nот 5 до 15 символов!";
                return false;
            }
            if (!usernameLengthValid)
            {
                labelPasswordErr.Visible = false;
                labelPasswordErr.Text = string.Empty;
                labelUsernameErr.ForeColor = System.Drawing.Color.Red;
                labelUsernameErr.Visible = true;
                labelUsernameErr.Text = "Логин должен иметь длину\nот 2 до 15 символов!";
                return false;
            }
            else if (!passwordLengthValid)
            {
                labelUsernameErr.Visible = false;
                labelUsernameErr.Text = string.Empty;
                labelPasswordErr.ForeColor = System.Drawing.Color.Red;
                labelPasswordErr.Visible = true;
                labelPasswordErr.Text = "Пароль должен иметь длину\nот 5 до 15 символов!";
                return false;
            }
            else if (Username.Equals("admin"))
            {
                labelUsernameErr.ForeColor = System.Drawing.Color.Red;
                labelUsernameErr.Visible = true;
                labelUsernameErr.Text = "Такой пользователь уже существует";
                return false;
            }
            else
            {
                labelUsernameErr.Visible = false;
                labelUsernameErr.Text = string.Empty;
                labelPasswordErr.Visible = false;
                labelPasswordErr.Text = string.Empty;
                return true;
            }
        }

        private bool IsValidEmail()
        {
            try
            {
                Email = new MailAddress(textBoxEmail.Text.Trim()).Address;
                labelEmailError.Text = "";
                labelEmailError.Visible = false;
                return true;
            }
            catch (ArgumentException)
            {
                labelEmailError.Text = "Адрес электронной почты должен быть заполнен!";
                labelEmailError.ForeColor = System.Drawing.Color.Red;
                labelEmailError.Visible = true;
                return false;
            }
            catch (FormatException)
            {
                labelEmailError.Text = "Неправильный адрес электронной почты!";
                labelEmailError.ForeColor = System.Drawing.Color.Red;
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

        private bool IsFullNameEmpty()
        {
            FullName = FullName.Trim();
            if (FullName.Equals(string.Empty))
                return true;
            else
                return false;
        }

        private bool CheckFullName()
        {
            bool empty = IsFullNameEmpty();
            if (empty)
            {
                labelFullNameErr.Text = "Нужно заполнить ФИО";
                labelFullNameErr.ForeColor = System.Drawing.Color.Red;
                labelFullNameErr.Visible = true;
            }
            else
            {
                labelFullNameErr.Text = string.Empty;
                labelFullNameErr.Visible = false;
            }
            return !empty;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            bool usernameAndPasswordCorrect = CheckUsernameAndPassword();
            bool fullNameCorrect = CheckFullName();
            bool emailValid = IsValidEmail();
            if (usernameAndPasswordCorrect && fullNameCorrect && emailValid)
            {
                if (IsValidEmail())
                {
                    TransformPhoneNumber();
                    CorrectInfo = true;
                    UpdateData?.Invoke();
                    if (CorrectInfo)
                        Close();
                }
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