using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bookshop.Classes
{
    public class Admin : User, IAdmin
    {
        //int key = -10;

        public Admin() { }

        //public Admin(string username, string password) : base(username, password) { }

        public void addCustomer(Customer customer)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO customer (customer_name, phone, email, address, username, password) VALUES (@full_name, @phone, @email, @address, @username, @password)", db.getConnection());

            try
            {
                command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = customer.customerName;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.phone;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.email;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.address;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = customer.username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = customer.password;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account has been successfully saved!" + "\n\n" +
                                    "Обліковий запис успішно збережено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Account creation failed!" + "\n\n" +
                                    "Помилка створення облікового запису!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateCustomer(Customer customer, int key)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE customer SET customer_name = @full_name, phone = @phone, email = @email, address = @address, username = @username, password = @password WHERE customer_id = " + key + ";", db.getConnection());

            try
            {
                command.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = customer.customerName;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.phone;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.email;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.address;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = customer.username;
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

        public void deleteCustomer(int key)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM customer WHERE customer_id = " + key + ";", db.getConnection());

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Customer has been Deleted Successfully!" + "\n\n" +
                                "Користувача успішно видалено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account deleting failed!" + "\n\n" +
                                "Помилка видалення облікового запису!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.CloseConnection();
        }

        public void addBook(Book book)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO book (title, pages, price, quantity, genre_id, author_id, publisher_id) VALUES (@title, @pages, @price, @quantity, @genre_id, @author_id, @publisher_id)", db.getConnection());

            try
            {
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = book.title;
                command.Parameters.Add("@pages", MySqlDbType.Int32).Value = book.pages;
                command.Parameters.Add("@price", MySqlDbType.Int32).Value = book.price;
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = book.quantity;
                command.Parameters.Add("@genre_id", MySqlDbType.Int32).Value = book.genre.genreId;
                command.Parameters.Add("@author_id", MySqlDbType.Int32).Value = book.author.authorId;
                command.Parameters.Add("@publisher_id", MySqlDbType.Int32).Value = book.publisher.publisherId;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book has been successfully saved!" + "\n\n" +
                                    "Книгу успішно збережено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book saving failed!" + "\n\n" +
                                    "Помилка збереження книги!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateBook(Book book, int key)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE book SET title = @title, pages = @pages, price = @price, quantity = @quantity, genre_id = @genre_id, author_id = @author_id, publisher_id = @publisher_id WHERE book_id = " + key + ";", db.getConnection());

            try
            {
                command.Parameters.Add("@title", MySqlDbType.VarChar).Value = book.title;
                command.Parameters.Add("@pages", MySqlDbType.Int32).Value = book.pages;
                command.Parameters.Add("@price", MySqlDbType.Int32).Value = book.price;
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = book.quantity;
                command.Parameters.Add("@genre_id", MySqlDbType.Int32).Value = book.genre.genreId;
                command.Parameters.Add("@author_id", MySqlDbType.Int32).Value = book.author.authorId;
                command.Parameters.Add("@publisher_id", MySqlDbType.Int32).Value = book.publisher.publisherId;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book has been successfully updated!" + "\n\n" +
                                    "Книгу успішно відредаговано!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book updating failed!" + "\n\n" +
                                    "Помилка редагування книги!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteBook(int key)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM book WHERE book_id = " + key + ";", db.getConnection());

            try
            {
                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Book has been Deleted Successfully!" + "\n\n" +
                                    "Книгу успішно видалено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book deleting failed!" + "\n\n" +
                                    "Помилка видалення книги!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addGenre(Genre genre)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO genre (genre_name) VALUES (@genre_name)", db.getConnection());

            try
            {
                command.Parameters.Add("@genre_name", MySqlDbType.VarChar).Value = genre.genreName;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Genre has been successfully saved!" + "\n\n" +
                                    "Жанр успішно добавлено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre saving failed!" + "\n\n" +
                                    "Помилка додавання жанру!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteGenre(int keyGenre)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM genre WHERE genre_id = " + keyGenre + ";", db.getConnection());
                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Genre has been Deleted Successfully!" + "\n\n" +
                                    "Жанр успішно видалено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre deleting failed!" + "\n\n" +
                                    "Помилка видалення жанру!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addAuthor(Author author)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO author (author_name) VALUES (@author_name)", db.getConnection());

            try
            {
                command.Parameters.Add("@author_name", MySqlDbType.VarChar).Value = author.authorName;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Author has been successfully saved!" + "\n\n" +
                                    "Автора успішно добавлено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre saving failed!" + "\n\n" +
                                    "Помилка додавання автора!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteAuthor(int keyAuthor)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM author WHERE author_id = " + keyAuthor + ";", db.getConnection());
                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Author has been Deleted Successfully!" + "\n\n" +
                                    "Автора успішно видалено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Author deleting failed!" + "\n\n" +
                                    "Помилка видалення автора!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addPublisher(Publisher publisher)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO publisher (publisher_name) VALUES (@publisher_name)", db.getConnection());

            try
            {
                command.Parameters.Add("@publisher_name", MySqlDbType.VarChar).Value = publisher.publisherName;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Publisher has been successfully saved!" + "\n\n" +
                                    "Видавництво успішно добавлено!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Publisher saving failed!" + "\n\n" +
                                    "Помилка додавання видавництва!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deletePublisher(int keyPublisher)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM publisher WHERE publisher_id = " + keyPublisher + ";", db.getConnection());
            try
            {
                db.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Publisher has been Deleted Successfully" + "\n\n" +
                                "Видавництво успішно видалено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchOrder(DataGridView dataGridView, string param, int id)
        {
            try
            {
                DB db = new DB();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM order_book_customer WHERE {param} = {id}", db.getConnection());

                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "order_book_customer");
                dataGridView.DataSource = ds.Tables["order_book_customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteNullData(string tableName, string param1, string param2)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"DELETE FROM `{tableName}` WHERE {param1} is NULL OR {param2} is NULL;", db.getConnection());
            try
            {
                db.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Blank spaces have been Successfully Deleted" + "\n\n" +
                                "Порожні місця було успішно видалено", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
