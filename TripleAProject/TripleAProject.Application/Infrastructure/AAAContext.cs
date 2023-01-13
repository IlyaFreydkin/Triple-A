using TripleAProject.Webapi.Model;
using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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
            Randomizer.Seed = new Random(1619);
            var faker = new Faker("de");


            var users = new Faker<User>("de").CustomInstantiator(f =>
            {
                return new User(
                    name: f.Name.LastName().ToLower(),
                    email: $"{f.Name.FirstName()}@gmail.at",
                    password: "1111",
                    role: f.PickRandom<Userrole>())
                { Guid = f.Random.Guid() };
            })
            .Generate(20)
            .ToList();
            Users.AddRange(users);
            SaveChanges();

            var genres = new Faker<Genre>("de").CustomInstantiator(f =>
            {
                return new Genre(
                    name: f.Commerce.Categories(1).First())
                { Guid = f.Random.Guid() };
            })
            .Generate(15)
            .GroupBy(c => c.Name).Select(g => g.First())
            .ToList();
            Genres.AddRange(genres);
            SaveChanges();

            var movies = new Faker<Movie>("de").CustomInstantiator(f =>
            {
                return new Movie(
                    title: f.Lorem.Sentence(),
                    link: f.Internet.Url(),
                    created: f.Date.Between(new DateTime(2021, 1, 1), new DateTime(2022, 1, 1)),
                    genre: Genres.OrderBy(g => Guid.NewGuid()).First())
                { Guid = f.Random.Guid() };
            })
            .Generate(20)
            .ToList();
            Movies.AddRange(movies);
            SaveChanges();

            var movieratings = new Faker<MovieRating>("de").CustomInstantiator(f =>
            {
                return new MovieRating(
                    value: f.Random.Int(1, 5),
                    movie: f.Random.ListItem(movies),
                    user: f.Random.ListItem(users))
                { Guid = f.Random.Guid() };
            })
            .Generate(20)
            .ToList();
            MovieRatings.AddRange(movieratings);
            SaveChanges();
        }
    }
}