using Microsoft.EntityFrameworkCore;
using Services.DALModels;

namespace MovieRegistration.services
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieTable> movieTables { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Data Source=localhost;Initial Catalog=movieregistration;Integrated Security=True");
        }
    }
}
