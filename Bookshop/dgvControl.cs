using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bookshop
{
    public class dgvControl
    {
        public List<string> dataFill = new List<string>();

        public void fillDataGrid(string tableName, DataGridView dataGridView)
        {
            try
            {
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM `{tableName}`", db.getConnection());

                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, tableName);
                dataGridView.DataSource = ds.Tables[tableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillComboBox(string tableName, ComboBox comboBox, string id, string name)
        {
            try
            {
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand($"SELECT {id}, CONCAT({id}, '. ', {name}) AS Description FROM `{tableName}` GROUP BY {id}", db.getConnection());

                db.OpenConnection();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, tableName);
                comboBox.DataSource = ds.Tables[tableName];
                comboBox.ValueMember = id;
                comboBox.DisplayMember = "Description";
                comboBox.SelectedIndex = -1;
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataGridViewButtonColumn CreateBtnColumn(DataGridViewButtonColumn btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.CellTemplate.Style.BackColor = Color.White;
            btn.CellTemplate.Style.ForeColor = Color.Indigo;
            btn.CellTemplate.Style.Font = new Font("Tahoma", 15);
            btn.HeaderText = "Action";
            btn.Text = "X";
            btn.UseColumnTextForButtonValue = true;

            return btn;
        }
    }
}
