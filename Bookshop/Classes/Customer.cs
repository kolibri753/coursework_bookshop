using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bookshop.Classes
{
    public class Customer : User, ICustomer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public Customer() { }

        public Customer(string customerName, string phone, string email, string address, string username, string password)
            : base(username, password)
        {
            this.customerName = customerName;
            this.phone = phone;
            this.email = email;
            this.address = address;
        }
        
        public override bool isLogin()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `username` = @username", db.getConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This username is already taken!\nTry another one!" + "\n\n" +
                               "Це ім’я користувача (логін) вже зайнято!\nСпробуйте інше!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Register()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customer` (`customer_name`, `phone`, `email`, `address`, `username`, `password`) VALUES (@full_name, @phone, @email, @address, @username, @password)", db.getConnection());

            try
            {
                command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = customerName;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account has been successfully created!" + "\n\n" +
                                    "Обліковий запис успішно створено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account creation failed!" + "\n\n" +
                                    "Помилка створення облікового запису!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Problems with database!" + "\n\n" +
                                "Проблеми з базою даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void updateProfile(Customer customer)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE customer SET customer_name = @full_name, phone = @phone, email = @email, address = @address, password = @password WHERE username = '" + username + "';", db.getConnection());

            try
            {
                command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = customer.customerName;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.phone;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.email;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.address;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = customer.password;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account has been successfully updated!" + "\n\n" +
                                    "Обліковий запис успішно відредаговано!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account updating failed!" + "\n\n" +
                                    "Помилка редагування облікового запису!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int newOrder()
        {
            int orderId = 0;
            DB db = new DB();
            MySqlCommand command1 = new MySqlCommand("INSERT INTO `order` (total_price, customer_id) VALUES(NULL, NULL);", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT LAST_INSERT_ID();", db.getConnection());

            try
            {
                db.OpenConnection();
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order has been successfully started!" + "\n\n" +
                                    "Замовлення успішно розпочато!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to start an order!" + "\n\n" +
                                    "Не вдалося розпочати замовлення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                orderId = Convert.ToInt32(command2.ExecuteScalar());
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return orderId;
        }

        public void addToCart(Book book, Order order)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO book_order (book_id, quantity, book_price, order_id) VALUES (@book_id, @quantity, @book_price, @order_id);", db.getConnection());

            try
            {
                command.Parameters.Add("@book_id", MySqlDbType.Int32).Value = book.bookId;
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = book.quantity;
                command.Parameters.Add("@book_price", MySqlDbType.Int32).Value = book.quantity * book.price;
                command.Parameters.Add("@order_id", MySqlDbType.Int32).Value = order.orderId;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book has been successfully added to the cart!" + "\n\n" +
                                    "Книгу успішно додано до корзини!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add book to the cart!" + "\n\n" +
                                    "Помилка додавання книги до корзини!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong..." + "\n\n" +
                                "Щось пішло не так...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void deleteFromCart(Order order)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM book_order WHERE order_id = " + order.orderId + ";", db.getConnection());
                db.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Books have been Successfully Deleted from the Cart!" + "\n\n" +
                                    "Книги успішно видалено з корзини!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);            
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void confirmOrder(Order order, string login)
        {
            DB db = new DB();

            MySqlCommand command2 = new MySqlCommand("SELECT customer_id FROM customer WHERE username = '" + login + "';", db.getConnection());
            MySqlCommand command = new MySqlCommand("UPDATE `order` SET total_price = @total_price, customer_id = @customer_id WHERE order_id = @order_id", db.getConnection());

            try
            {
                db.OpenConnection();

                int user_id = (int)command2.ExecuteScalar();
                command.Parameters.Add("@total_price", MySqlDbType.Int32).Value = order.totalPrice;
                command.Parameters.Add("@customer_id", MySqlDbType.Int32).Value = user_id;
                command.Parameters.Add("@order_id", MySqlDbType.Int32).Value = order.orderId;

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order received and ready for processing!" + "\n\n" +
                                    "Замовлення отримано та в процесі обробки!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problems with the store!" + "\n\n" +
                                    "Проблеми з магазином!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Firstly add books to your shopping cart!" + "\n\n" +
                                "Спочатку додайте книги до корзини!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void searchBook(DataGridView dgv, TextBox tb)
        {
            try
            {
                DB db = new DB();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM user_order WHERE CONCAT(title, author_name) LIKE '%" + tb.Text + "%';", db.getConnection());

                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "book");
                dgv.DataSource = ds.Tables["book"];

                int rows = dgv.Rows.Count;
                MessageBox.Show("Discovered " + rows.ToString() + " books" + "\n\n" +
                                "Знайдено " + rows.ToString() + " книг(жок)", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
