using TripleAProject.Webapi.Model;
using Bogus;
using Bogus.DataSets;
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
                    name: f.Name.LastName(),
                    email: $"{f.Name.FirstName()}@gmail.at",
                    password: f.Internet.Password(),
                    role: f.PickRandom<Userrole>())
                    
                { Guid = f.Random.Guid() };
            })
            .Generate(20)
            .ToList();
            Users.AddRange(users);
            SaveChanges();           
         
            var movies = new Faker<Movie>("de").CustomInstantiator(f =>
            {
                return new Movie(
                    title: f.Lorem.Sentence(),
                    link: f.Internet.Url(),
                    genre: (new Genre(f.Name.FirstName())))

                 { Guid = f.Random.Guid() };

            })
                .Generate(20)
                .ToList();
                Movies.AddRange(movies);
                SaveChanges();

                  

           

            var genres = new Faker<Genre>("de").CustomInstantiator(f=>
            {
                return new Genre(
                    
                    name: f.Commerce.Categories(1).First())
                
                { Guid = f.Random.Guid() };
            })
            .Generate(15)
            .ToList();
            Genres.AddRange(genres);
            SaveChanges();




            //var genres = new Faker<Genre>("de").CustomInstantiator(f=>
            //{
            //    return new Genre(

            //        name: f.Name.FindName())

            //    { Guid = f.Random.Guid() };
            //})
            //    .Generate(15)
            //    .ToList();
            //    Genres.AddRange(genres);
            //    SaveChanges();

            var movieratings = new Faker<MovieRating>("de").CustomInstantiator(f =>
            {

                return new MovieRating(
                    value: f.Random.Int(1, 10),
                    movie: Movies.OrderBy(m => Guid.NewGuid()).First(),
                    user: Users.OrderBy(u => Guid.NewGuid()).First())
                { Guid = f.Random.Guid() };
            })


                .Generate(20)
                .ToList();
            MovieRatings.AddRange(movieratings);
            SaveChanges();


            

        }

    }
}

