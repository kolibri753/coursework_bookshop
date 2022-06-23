namespace Bookshop.Classes
{
    public class Book
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public int pages { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public Genre genre { get; set; }
        public Author author { get; set; }
        public Publisher publisher { get; set; }

        public Book() { }

        public Book(int id, int quantity, int price)
        {
            this.bookId = id;
            this.quantity = quantity;
            this.price = price;
        }

        public Book(string title, int pages, int price, int quantity, int genreId, int authorId, int publisherId)
        {
            this.title = title;
            this.pages = pages;
            this.price = price;
            this.quantity = quantity;
            this.genre = new Genre(genreId);
            this.author = new Author(authorId);
            this.publisher = new Publisher(publisherId);
        }

        public Book(int id, string title, int pages, int price, int quantity, int genreId, int authorId, int publisherId)
        {
            this.bookId = id;
            this.title = title;
            this.pages = pages;
            this.price = price;
            this.quantity = quantity;
            this.genre = new Genre(genreId);
            this.author = new Author(authorId);
            this.publisher = new Publisher(publisherId);
        }
    }
}
