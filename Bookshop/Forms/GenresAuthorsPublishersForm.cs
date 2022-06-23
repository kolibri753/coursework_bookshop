using Bookshop.Classes;
using System;
using System.Windows.Forms;

namespace Bookshop.Forms
{
    public partial class GenresAuthorsPublishersForm : Form
    {
        readonly dgvControl dgv = new dgvControl();
        public int keyGenre = 0;
        public int keyAuthor = 0;
        public int keyPublisher = 0;

        public GenresAuthorsPublishersForm()
        {
            InitializeComponent();
            dgv.fillDataGrid("genre", dgvGenres);
            dgv.fillDataGrid("author", dgvAuthors);
            dgv.fillDataGrid("publisher", dgvPublishers);

            dgvGenres.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuthors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPublishers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn btnGenres = new DataGridViewButtonColumn();
            dgvGenres.Columns.Add(dgv.CreateBtnColumn(btnGenres));
            DataGridViewButtonColumn btnAuthors = new DataGridViewButtonColumn();
            dgvAuthors.Columns.Add(dgv.CreateBtnColumn(btnAuthors));
            DataGridViewButtonColumn btnPublishers = new DataGridViewButtonColumn();
            dgvPublishers.Columns.Add(dgv.CreateBtnColumn(btnPublishers));
        }

        private void btnGenreAdd_Click(object sender, EventArgs e)
        {
            if (tbGenreName.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Genre genre = new Genre(tbGenreName.Text);
                admin.addGenre(genre);
                dgv.fillDataGrid("genre", dgvGenres);
                tbGenreName.Text = "";
            }
        }

        private void dgvGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                keyGenre = Convert.ToInt32(dgvGenres.SelectedRows[0].Cells[1].Value.ToString());
                Admin admin = new Admin();
                admin.deleteGenre(keyGenre);
                dgv.fillDataGrid("genre", dgvGenres);
                tbGenreName.Text = "";
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            if (tbAuthorName.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Author author = new Author(tbAuthorName.Text);
                admin.addAuthor(author);
                dgv.fillDataGrid("author", dgvAuthors);
                tbAuthorName.Text = "";
            }
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                keyAuthor = Convert.ToInt32(dgvAuthors.SelectedRows[0].Cells[1].Value.ToString());
                Admin admin = new Admin();
                admin.deleteAuthor(keyAuthor);
                dgv.fillDataGrid("author", dgvAuthors);
                tbAuthorName.Text = "";
            }
        }

        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            if (tbPublisherName.Text == "")
            {
                MessageBox.Show("Empty fields!" + "\n\n" +
                                "Порожні поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Admin admin = new Admin();
                Publisher publisher = new Publisher(tbPublisherName.Text);
                admin.addPublisher(publisher);
                dgv.fillDataGrid("publisher", dgvPublishers);
                tbPublisherName.Text = "";
            }
        }

        private void dgvPublishers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                keyPublisher = Convert.ToInt32(dgvPublishers.SelectedRows[0].Cells[1].Value.ToString());
                Admin admin = new Admin();
                admin.deletePublisher(keyPublisher);
                dgv.fillDataGrid("publisher", dgvPublishers);
                tbPublisherName.Text = "";
            }
        }
    }
}
