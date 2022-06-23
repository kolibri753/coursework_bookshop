using MySql.Data.MySqlClient;
using System.Data;

namespace Bookshop.Classes
{
    public /*abstract*/ class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public virtual bool isLogin()
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
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `username` = @username AND `password` = @password", db.getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
