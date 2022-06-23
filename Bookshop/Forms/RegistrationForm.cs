using Bookshop.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class RegistrationForm : System.Windows.Forms.Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            tbFullName.Text = "Введіть ім'я";
            tbFullName.ForeColor = Color.MediumPurple;

            tbPhone.Text = "Введіть номер телефону";
            tbPhone.ForeColor = Color.MediumPurple;

            tbEmail.Text = "Введіть електронну адресу";
            tbEmail.ForeColor = Color.MediumPurple;

            tbAddress.Text = "Введіть місце проживання";
            tbAddress.ForeColor = Color.MediumPurple;

            tbUsername.Text = "Введіть логін";
            tbUsername.ForeColor = Color.MediumPurple;

            tbPassword.Text = "********";
            tbPassword.ForeColor = Color.MediumPurple;
            tbPassword.PasswordChar = '*';

            tbConfirmPassword.Text = "********";
            tbConfirmPassword.ForeColor = Color.MediumPurple;
            tbConfirmPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(tbFullName.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text, tbUsername.Text, tbPassword.Text);
            bool isLogin = customer.isLogin();

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password confirmation doesn't match!" + "\n\n" +
                                "Паролі не співпадають!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbFullName.Text == "Введіть ім'я" || tbPhone.Text == "Введіть номер телефону" ||
                tbEmail.Text == "Введіть електронну адресу" || tbAddress.Text == "Введіть місце проживання" ||
                tbUsername.Text == "Введіть логін" || tbPassword.Text == "********" ||
                tbConfirmPassword.Text == "********")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!isLogin)
            {
                customer.Register();
            }

        }

        private void tbFullName_Enter(object sender, EventArgs e)
        {
            if (tbFullName.Text == "Введіть ім'я")
            {
                tbFullName.Text = "";
                tbFullName.ForeColor = Color.Indigo;
            }
        }

        private void tbFullName_Leave(object sender, EventArgs e)
        {
            if (tbFullName.Text == "")
            {
                tbFullName.Text = "Введіть ім'я";
                tbFullName.ForeColor = Color.MediumPurple;
            }
        }

        private void tbPhone_Enter(object sender, EventArgs e)
        {
            if (tbPhone.Text == "Введіть номер телефону")
            {
                tbPhone.Text = "";
                tbPhone.ForeColor = Color.Indigo;
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Text = "Введіть номер телефону";
                tbPhone.ForeColor = Color.MediumPurple;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Введіть електронну адресу")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Indigo;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Введіть електронну адресу";
                tbEmail.ForeColor = Color.MediumPurple;
            }
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            if (tbAddress.Text == "Введіть місце проживання")
            {
                tbAddress.Text = "";
                tbAddress.ForeColor = Color.Indigo;
            }
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            if (tbAddress.Text == "")
            {
                tbAddress.Text = "Введіть місце проживання";
                tbAddress.ForeColor = Color.MediumPurple;
            }
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

        private void tbConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text == "********")
            {
                tbConfirmPassword.Text = "";
                tbConfirmPassword.ForeColor = Color.Indigo;
            }
        }
        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text == "")
            {
                tbConfirmPassword.Text = "********";
                tbConfirmPassword.ForeColor = Color.MediumPurple;
            }
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            this.Hide();
            form.Show();
        }
    }
}
