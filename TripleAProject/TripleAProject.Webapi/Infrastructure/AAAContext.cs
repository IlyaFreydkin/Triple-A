using Microsoft.EntityFrameworkCore;
using TripleAProject.Webapi.Model;

namespace TripleAProject.Webapi.Infrastructure
{
    public class AAAContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Rating> Ratings => Set<Rating>();
        public DbSet<Genre> Genres => Set<Genre>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public void Seed()
        {

        }
    }
}
