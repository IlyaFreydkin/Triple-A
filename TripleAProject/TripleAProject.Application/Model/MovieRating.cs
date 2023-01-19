using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    public class MovieRating
    {
#pragma warning disable CS8618
        protected MovieRating() { }
#pragma warning restore CS8618

        public MovieRating(int value, Movie movie, User user)
        {
            Value = value;
            Movie = movie;
            User = user;
        }
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; private set; }
        [Range(1,5)]

        public int Value { get;  set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
        public Guid Guid { get; set; }

    }
}
