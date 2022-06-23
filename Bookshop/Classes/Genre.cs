namespace Bookshop.Classes
{
    public class Genre
    {
        public int genreId { get; set; }

        public string genreName { get; set; }

        public Genre(int genreId)
        {
            this.genreId = genreId;
        }

        public Genre(string genreName)
        {
            this.genreName = genreName;
        }


    }
}
