﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace supinfo._3asp.koombu.Models
{
    public class UserModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        public string LastName { get; set; }

      /*  [Required(ErrorMessage = "Champ obligatoire")]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        public string Department { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        public string Title { get; set; }
        */
        [Required(ErrorMessage = "champ obligatoire")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "champ obligatoire")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Champ obligatoire")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        // Couche DAL 
        // todo Data Access Library
        public class UserContext : DbContext
        {
            public DbSet<UserModel> Users { get; set; }

            public UserContext() : base("UserContext")
            {
            }

            public static UserContext Create()
            {
                return new UserContext();
            }
        }

    }
}