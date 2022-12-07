using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    public class Movie
    {
#pragma warning disable CS8618
        protected Movie() { }

#pragma warning restore CS8618
        public Movie(string title, string link, Rating rating)
        {
            Title = title;
            Link = link;
            Rating = rating;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public Rating Rating { get; set; }  
    }
}
