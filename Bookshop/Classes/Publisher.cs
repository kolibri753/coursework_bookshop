namespace Bookshop.Classes
{
    public class Publisher
    {
        public int publisherId { get; set; }

        public string publisherName { get; set; }

        public Publisher(int publisherId)
        {
            this.publisherId = publisherId;
        }

        public Publisher(string publisherName)
        {
            this.publisherName = publisherName;
        }
    }
}
