using Bookshop.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class AuthorizationForm : System.Windows.Forms.Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();

            tbUsername.Text = "Введіть логін";
            tbUsername.ForeColor = Color.MediumPurple;

            tbPassword.Text = "********";
            tbPassword.ForeColor = Color.MediumPurple;
            tbPassword.PasswordChar = '*';
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            this.Hide();
            form.Show();
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Введіть логін")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Indigo;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Введіть логін";
                tbUsername.ForeColor = Color.MediumPurple;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "********")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Indigo;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "********";
                tbPassword.ForeColor = Color.MediumPurple;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User(tbUsername.Text, tbPassword.Text);

            bool isLogin = user.isLogin();
            bool validateUser = user.ValidateUser();

            if (validateUser)
            {
                if (tbUsername.Text == "admin")
                {
                    FormMainMenu form = new FormMainMenu();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    UserMenuForm form = new UserMenuForm();
                    form.login = user.username;
                    this.Hide();
                    form.Show();

                    //MessageBox.Show("Hello " + user.username);
                }
            }
            else
            {
                if (isLogin)
                {
                    MessageBox.Show("Password is wrong!" + "\n\n" +
                                    "Неправильний пароль!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("You are here for the first time?\nReturn back to register form?" + "\n\n" +
                                        "Ви тут вперше?\nПовернутись до реєстрації?", "Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        RegistrationForm form = new RegistrationForm();
                        this.Hide();
                        form.Show();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
