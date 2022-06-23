using Bookshop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class CartForm : Form
    {
        readonly dgvControl dgv = new dgvControl();
        Customer customer = new Customer();

        public string _login;

        int keyBook = 0, stock = 0, n = 0;
        int cart_price, book_price = 0;

        public CartForm()
        {
            InitializeComponent();

            dgv.fillDataGrid("book", dgvBooks);
            dgvBooks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn btnBookOrder = new DataGridViewButtonColumn();
            dgvShoppingCart.Columns.Add(dgv.CreateBtnColumn(btnBookOrder));
        }
        
        private void Reset()
        {
            tbBookId.Text = "";
            tbQuantity.Text = "";
            tbPrice.Text = "";

            keyBook = 0;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            tbOrderId.Text = customer.newOrder().ToString();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (tbOrderId.Text == "")
            {
                MessageBox.Show("Press New Order and only than add books to the cart!" + "\n\n" +
                                "Натисніть Нове замовлення і лише тоді додавайте книги в кошик!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbQuantity.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(tbQuantity.Text) > stock)
            {
                MessageBox.Show("Not available!" + "\n\n" +
                                "Немає у наявності!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Book book = new Book(Convert.ToInt32(tbBookId.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToInt32(tbPrice.Text));
                Order order = new Order(Convert.ToInt32(tbOrderId.Text));

                dgv.fillDataGrid("book", dgvBooks);

                DataGridViewRow newRow = new DataGridViewRow();

                customer.addToCart(book, order);
                book_price = book.quantity * book.price;

                newRow.CreateCells(dgvShoppingCart);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = book.bookId;
                newRow.Cells[2].Value = book.quantity;
                newRow.Cells[3].Value = book.price;
                newRow.Cells[4].Value = book_price;
                dgvShoppingCart.Rows.Add(newRow);
                cart_price = cart_price + book_price;
                labelTotalPrice.Text = Convert.ToString(cart_price);
                n++;

                updateStock();
                Reset();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (labelTotalPrice.Text == "Total Price")
            {
                MessageBox.Show("Add books to the Cart!" + "\n\n" +
                                "Додайте книг до корзини!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Order order = new Order(Convert.ToInt32(tbOrderId.Text), Convert.ToInt32(labelTotalPrice.Text));
            customer.confirmOrder(order, _login);
            dgvShoppingCart.Rows.Clear();
            labelTotalPrice.Text = "Total Price";
            tbOrderId.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customer.searchBook(dgvBooks, tbSearch);
        }

        private void dgvShoppingCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = new Order(Convert.ToInt32(tbOrderId.Text));

            if (e.ColumnIndex == 5)
            {
                customer.deleteFromCart(order);
                dgvShoppingCart.Rows.Clear();
                labelTotalPrice.Text = "Total Price";
                tbOrderId.Text = "";
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookId.Text = dgvBooks.SelectedRows[0].Cells[0].Value.ToString();
            tbPrice.Text = dgvBooks.SelectedRows[0].Cells[3].Value.ToString();

            if (tbBookId.Text == "")
            {
                keyBook = 0;
            }
            else
            {
                keyBook = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void updateStock()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE book SET quantity = @quantity WHERE book_id = " + keyBook + ";", db.getConnection());
            try
            {
                int newStock = stock - Convert.ToInt32(tbQuantity.Text);
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = newStock;

                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
                dgv.fillDataGrid("book", dgvBooks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
