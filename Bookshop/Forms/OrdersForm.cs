using Bookshop.Classes;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class OrdersForm : Form
    {
        readonly dgvControl dgv = new dgvControl();
        Admin admin = new Admin();
        int orderId;
        int customerId;

        public OrdersForm()
        {
            InitializeComponent();

            dgv.fillDataGrid("order", dgvOrders);
            dgv.fillComboBox("order", cbOrderId, "order_id", "total_price");
            dgv.fillComboBox("order_book_customer", cbCustomerId, "customer_id", "customer_name");
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            cbOrderId.SelectedIndexChanged += cbOrderId_SelectedIndexChanged;
            cbCustomerId.SelectedIndexChanged += cbCustomerId_SelectedIndexChanged;
        }

        private void cbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOrderId.Text = "";
            customerId = (int)cbCustomerId.SelectedValue;
            admin.searchOrder(dgvBookOrder, "customer_id", customerId);
        }

        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCustomerId.Text = "";
            orderId = (int)cbOrderId.SelectedValue;
            admin.searchOrder(dgvBookOrder, "order_id", orderId);
        }

        private void btnDeleteNull_Click(object sender, EventArgs e)
        {
            admin.deleteNullData("order", "total_price", "customer_id");
            dgv.fillDataGrid("order", dgvOrders);
        }
    }
}
