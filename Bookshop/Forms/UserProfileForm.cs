using Bookshop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class UserProfileForm : Form
    {
        public string _login;
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = _login;

            try
            {
                DB db = new DB();

                MySqlDataReader reader;
                MySqlCommand command = new MySqlCommand($"SELECT * FROM customer WHERE username = '{_login}'", db.getConnection());

                db.OpenConnection();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbFullName.Text = reader.GetString("customer_name");
                    tbPhone.Text = reader.GetString("phone");
                    tbEmail.Text = reader.GetString("email");
                    tbAddress.Text = reader.GetString("address");
                    tbPassword.Text = reader.GetString("password");
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAddress.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Customer customer = new Customer(tbFullName.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text, labelUsername.Text, tbPassword.Text);
                customer.updateProfile(customer);
            }
        }
    }
}
