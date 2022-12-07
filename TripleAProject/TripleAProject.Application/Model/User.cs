using Microsoft.EntityFrameworkCore;
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

        public User(string name, string password, string email, bool admin)
        {
            Name = name;
            Password = password;
            Email = email;
            Admin = admin;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Name { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }   
        public string Email { get; set; }   
        public bool Admin { get; set; }
        
    }
}
