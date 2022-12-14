using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    public class Movie
    {
#pragma warning disable CS8618
        protected Movie() { }

#pragma warning restore CS8618
        public Movie(string title, string link, Rating rating, Genre genre, User user)
        {
            Title = title;
            Link = link;
            Rating = rating;
            Genre = genre;
            User = user;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public Rating Rating { get; set; }  
        public Genre Genre { get; set; }
        public User User { get; set; }
    }
}
