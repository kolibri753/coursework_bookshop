using Bookshop.Classes;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class BooksForm : System.Windows.Forms.Form
    {
        readonly dgvControl dgv = new dgvControl();

        int key = 0;
        int genreId;
        int authorId;
        int publisherId;

        public BooksForm()
        {
            InitializeComponent();

            dgv.fillDataGrid("book", dgvBooks);
            dgv.fillComboBox("genre", cbGenreId, "genre_id", "genre_name");
            dgv.fillComboBox("author", cbAuthorId, "author_id", "author_name");
            dgv.fillComboBox("publisher", cbPublisherId, "publisher_id", "publisher_name");

            dgvBooks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            cbGenreId.SelectedIndexChanged += cbGenreId_SelectedIndexChanged;
            cbAuthorId.SelectedIndexChanged += cbAuthorId_SelectedIndexChanged;
            cbPublisherId.SelectedIndexChanged += cbPublisherId_SelectedIndexChanged;
        }

        private void cbGenreId_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreId = (int)cbGenreId.SelectedValue;
        }

        private void cbAuthorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            authorId = (int)cbAuthorId.SelectedValue;
        }

        private void cbPublisherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            publisherId = (int)cbPublisherId.SelectedValue;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTitle.Text = dgvBooks.SelectedRows[0].Cells[1].Value.ToString();
            tbPages.Text = dgvBooks.SelectedRows[0].Cells[2].Value.ToString();
            tbPrice.Text = dgvBooks.SelectedRows[0].Cells[3].Value.ToString();
            tbQuantity.Text = dgvBooks.SelectedRows[0].Cells[4].Value.ToString();
            cbGenreId.SelectedValue = dgvBooks.SelectedRows[0].Cells[5].Value.ToString();
            cbAuthorId.SelectedValue = dgvBooks.SelectedRows[0].Cells[6].Value.ToString();
            cbPublisherId.SelectedValue = dgvBooks.SelectedRows[0].Cells[7].Value.ToString();

            if (tbTitle.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Reset()
        {
            tbTitle.Text = "";
            tbPages.Text = "";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            cbGenreId.Text = "";
            cbAuthorId.Text = "";
            cbPublisherId.Text = "";

            key = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbPages.Text == "" || tbPrice.Text == "" || tbQuantity.Text == "" || cbGenreId.Text == "" || cbAuthorId.Text == "" || cbPublisherId.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Admin admin = new Admin();
                Book book = new Book(tbTitle.Text, Convert.ToInt32(tbPages.Text), Convert.ToInt32(tbPrice.Text), Convert.ToInt32(tbQuantity.Text), genreId, authorId, publisherId);
                admin.addBook(book);
                dgv.fillDataGrid("book", dgvBooks);
                Reset();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbPages.Text == "" || tbPrice.Text == "" || tbQuantity.Text == "" || cbGenreId.Text == "" || cbAuthorId.Text == "" || cbPublisherId.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Book book = new Book(tbTitle.Text, Convert.ToInt32(tbPages.Text), Convert.ToInt32(tbPrice.Text), Convert.ToInt32(tbQuantity.Text), genreId, authorId, publisherId);
                admin.updateBook(book, key);
                dgv.fillDataGrid("book", dgvBooks);
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
                admin.deleteBook(key);
                dgv.fillDataGrid("book", dgvBooks);
                Reset();
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
