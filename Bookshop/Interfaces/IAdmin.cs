using System.Windows.Forms;

namespace Bookshop.Classes
{
    interface IAdmin
    {
        void addAuthor(Author author);
        void addBook(Book book);
        void addCustomer(Customer customer);
        void addGenre(Genre genre);
        void addPublisher(Publisher publisher);
        void deleteAuthor(int keyAuthor);
        void deleteBook(int key);
        void deleteCustomer(int key);
        void deleteGenre(int keyGenre);
        void deletePublisher(int keyPublisher);
        void deleteNullData(string tableName, string param1, string param2);
        void searchOrder(DataGridView dataGridView, string param, int id);
        void updateBook(Book book, int key);
        void updateCustomer(Customer customer, int key);
    }
}