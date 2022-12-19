﻿using Microsoft.EntityFrameworkCore;
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
        public string Name { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }   
        public string Email { get; set; }   
        public Userrole Role { get; set; }
        public Guid Guid { get; set; }
    }
}