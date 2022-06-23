using System.Windows.Forms;

namespace Bookshop.Classes
{
    interface ICustomer
    {
        int customerId { get; set; }
        string address { get; set; }
        string customerName { get; set; }
        string phone { get; set; }

        bool isLogin();
        void Register();
        int newOrder();
        void addToCart(Book book, Order order);
        void confirmOrder(Order order, string login);
        void searchBook(DataGridView dgv, TextBox tb);
        void updateProfile(Customer customer);
    }
}