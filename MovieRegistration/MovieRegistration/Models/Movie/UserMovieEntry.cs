using Services.DALModels;

namespace MovieRegistration.Models.Movie
{
    public class UserMovieEntry
    {
        private object movie;

        public UserMovieEntry(object movie)
        {
            this.movie = movie;
        }

        public MovieTable Movie { get; set; }
    }
}
