using Bookshop.Classes;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class CustomersForm : System.Windows.Forms.Form
    {
        readonly dgvControl dgv = new dgvControl();
        int key = 0;

        public CustomersForm()
        {
            InitializeComponent();
            dgv.fillDataGrid("customer", dgvCustomers);
            this.dgvCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = dgvCustomers.SelectedRows[0].Cells[1].Value.ToString();
            tbPhone.Text = dgvCustomers.SelectedRows[0].Cells[2].Value.ToString();
            tbEmail.Text = dgvCustomers.SelectedRows[0].Cells[3].Value.ToString();
            tbAddress.Text = dgvCustomers.SelectedRows[0].Cells[4].Value.ToString();
            tbUsername.Text = dgvCustomers.SelectedRows[0].Cells[5].Value.ToString();
            tbPassword.Text = dgvCustomers.SelectedRows[0].Cells[6].Value.ToString();

            if (tbName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            tbName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            key = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAddress.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Password confirmation doesn't match!" + "\n\n" +
                                "Паролі не співпадають!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Customer customer = new Customer(tbName.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text, tbUsername.Text, tbPassword.Text);
                bool isLogin = customer.isLogin();

                if (!isLogin)
                {
                    admin.addCustomer(customer);
                    dgv.fillDataGrid("customer", dgvCustomers);
                    Reset();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAddress.Text == "" || tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Password confirmation doesn't match!" + "\n\n" +
                                "Паролі не співпадають!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Customer customer = new Customer(tbName.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text, tbUsername.Text, tbPassword.Text);
                admin.updateCustomer(customer, key);
                dgv.fillDataGrid("customer", dgvCustomers);
                Reset();
            }
        }

        private void bntDetele_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                admin.deleteCustomer(key);
                dgv.fillDataGrid("customer", dgvCustomers);
                Reset();
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
