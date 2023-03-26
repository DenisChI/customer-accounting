using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class AuthView : Form, IAuthView
    {
        public string Username { get { return textBoxUsername.Text; } set { textBoxUsername.Text = value; } }
        public string Password { get { return textBoxPassword.Text; } set { textBoxPassword.Text = value; } }
        public Label UsernameError { get {return labelUsernameErr; } set { labelUsernameErr = value; } }
        public Label PasswordError { get {return labelPassErr; } set { labelPassErr = value; } }

        public event Action Auth;

        public AuthView()
        {
            InitializeComponent();
        }

        public void ShowAuthView()
        {
            Show();
        }

        private bool IsUsernameLengthValid()
        {
            if (Username.Length < 2)
                return false;
            else
                return true;
        }

        private bool IsPasswordLengthValid()
        {
            if (Password.Length < 5)
                return false;
            else
                return true;
        }

        private bool CheckTextBoxes()
        {
            bool usernameLengthValid = IsUsernameLengthValid();
            bool passwordLengthValid = IsPasswordLengthValid();
            if (usernameLengthValid && passwordLengthValid)
            {
                return true;
            }
            else if (!usernameLengthValid)
            {
                labelUsernameErr.ForeColor = System.Drawing.Color.Red;
                labelUsernameErr.Visible = true;
                labelUsernameErr.Text = "Логин должен иметь длину\nот 2 до 15 символов!";
                return false;
            }
            else if (!passwordLengthValid)
            {
                labelPassErr.ForeColor = System.Drawing.Color.Red;
                labelPassErr.Visible = true;
                labelPassErr.Text = "Пароль должен иметь длину\nот 5 до 15 символов!";
                return false;
            }
            else
            {
                labelUsernameErr.ForeColor = System.Drawing.Color.Red;
                labelUsernameErr.Visible = true;
                labelUsernameErr.Text = "Логин должен иметь длину\nот 2 до 15 символов!";
                labelPassErr.ForeColor = System.Drawing.Color.Red;
                labelPassErr.Visible = true;
                labelPassErr.Text = "Пароль должен иметь длину\nот 5 до 15 символов!";
                return false;
            }
        }

        private void ButtonAuth_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                Auth?.Invoke();
                //Close();
            }
        }

        public void HideView()
        {
            this.Hide();
        }

    }
}