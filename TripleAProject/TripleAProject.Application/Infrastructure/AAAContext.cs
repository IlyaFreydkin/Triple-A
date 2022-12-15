using Microsoft.EntityFrameworkCore;
using TripleAProject.Webapi.Model;

namespace TripleAProject.Webapi.Infrastructure
{
    public class AAAContext : DbContext
    {
        public AAAContext(DbContextOptions opt) : base(opt) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<MovieRating> MovieRatings => Set<MovieRating>();
        public DbSet<Genre> Genres => Set<Genre>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public void Seed()
        {

        }
    }
}
