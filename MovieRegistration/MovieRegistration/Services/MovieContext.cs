using Microsoft.EntityFrameworkCore;
using MovieRegistration.Services.DAL_Models;

namespace MovieRegistration.Services
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
