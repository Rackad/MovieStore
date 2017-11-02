namespace MovieStore.Models
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }

        // constructor
        public Movie(dynamic info)
        {

            id = info.imdbId;
            title = info.title;
            year = info.releaseYear;

        }

    }
}
