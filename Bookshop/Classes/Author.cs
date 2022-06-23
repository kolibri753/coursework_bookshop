namespace Bookshop.Classes
{
    public class Author
    {
        public int authorId { get; set; }

        public string authorName { get; set; }

        public Author(int authorId)
        {
            this.authorId = authorId;
        }

        public Author(string authorName)
        {
            this.authorName = authorName;
        }
    }
}
