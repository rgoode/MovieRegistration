using System.Collections.Generic;

namespace MovieRegistration.Models.Movie
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Directors { get; set; }

    }
}
