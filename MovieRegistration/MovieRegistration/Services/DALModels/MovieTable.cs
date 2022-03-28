namespace Services.DALModels
{
    public class MovieTable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        //public enum Genre
        //{
        //    Horror,
        //    Comedy,
        //    Romance,
        //    Animated,
        //    Action
        //}

        public int Year { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
       
    }
}