using FluentAssertions.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistration.Models.Movie
{
    public class IndexViewModel
    {

        //public IEnumerable<Services.DALModels.MovieTable> Movies
        public IEnumerable<Services.DALModels.MovieTable> Movies { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The maximum title Length must be 50 characters.")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Range(1880, 2022, ErrorMessage = "The Year Entered must be between 1880 and 2022")]
        public int Year { get; set; }
        
        public string Actor { get; set; }
        public string Director { get; set; }

        public string Genre { get; set; }

        //public enum Genre
        //{
        //    Horror, 
        //    Comedy,
        //    Romance,
        //    Animated,
        //    Action
        //}
        


        
        


        

    }
}
