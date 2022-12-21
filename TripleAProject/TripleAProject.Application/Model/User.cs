using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {

#pragma warning disable CS8618
        protected User() { }
#pragma warning restore CS8618

        public User(string name, string password, string email, Userrole role)
        {
            Name = name;
            Password = password;
            Email = email;
            Role = role;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        [MaxLength(255)]    
        public string Name { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [Range(0,1)]
        public Userrole Role { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }
    }
}
