namespace Bookshop.Classes
{
    public abstract class BookOrder
    {
        public int bookOrderId { get; set; }
        public Book book { get; set; }
        public Order order { get; set; }

        public BookOrder() { }

        public BookOrder(int bookOrderId, Book book, Order order)
        {
            this.bookOrderId = bookOrderId;
            this.book.quantity = book.quantity;
            this.book.price = book.price;
            this.book.bookId = book.bookId;
            this.order.orderId = order.orderId;
        }
    }
}
