using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    [Index(nameof(Name), IsUnique = true)]
    public class Genre
    {
#pragma warning disable CS8618
        protected Genre() { }
#pragma warning restore CS8618

        public Genre(string name)
        {
            Name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public Guid Guid { get; set; }
}
}
