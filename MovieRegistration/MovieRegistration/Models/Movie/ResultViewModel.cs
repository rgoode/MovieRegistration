using Services.DALModels;

namespace MovieRegistration.Models.Movie
{
    public class ResultViewModel
    {

        public ResultViewModel(MovieTable movie)
        {
            Movie = movie;
        }
        public MovieTable Movie { get; set; }

        public string Title { get; set; }
    }   
}
