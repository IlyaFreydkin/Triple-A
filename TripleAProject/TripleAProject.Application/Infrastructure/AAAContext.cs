
﻿using TripleAProject.Webapi.Model;
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
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var key in entityType.GetForeignKeys())
                    key.DeleteBehavior = DeleteBehavior.Restrict;

                foreach (var prop in entityType.GetDeclaredProperties())
                {
                    if (prop.Name == "Guid")
                    {
                        modelBuilder.Entity(entityType.ClrType).HasAlternateKey("Guid");
                        prop.ValueGenerated = Microsoft.EntityFrameworkCore.Metadata.ValueGenerated.OnAdd;
                    }
                    if (prop.ClrType == typeof(string) && prop.GetMaxLength() is null) prop.SetMaxLength(255);
                    if (prop.ClrType == typeof(DateTime)) prop.SetPrecision(3);
                    if (prop.ClrType == typeof(DateTime?)) prop.SetPrecision(3);
                }
            }
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
                    genre: Genres.OrderBy(g => Guid.NewGuid()).First())

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

            var movieratings = new Faker<MovieRating>("de").CustomInstantiator(f=>
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

