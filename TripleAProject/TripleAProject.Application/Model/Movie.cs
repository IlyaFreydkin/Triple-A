using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    public class Movie
    {
#pragma warning disable CS8618
        protected Movie() { }

#pragma warning restore CS8618

        public Movie(string title, string link, DateTime created, Genre genre)
        {
            Title = title;
            Link = link;
            Created = created;
            Genre = genre;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Link { get; set; }
        public Guid Guid { get; set; }
        public Genre Genre { get; set; }
        public DateTime Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public List<MovieRating> Rating { get; set; } = new();


    }
}
