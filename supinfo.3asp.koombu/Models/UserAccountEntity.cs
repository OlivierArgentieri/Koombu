using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace supinfo._3asp.koombu.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
    }

    // Couche DAL 
    // todo Data Access Library
    public class UserContext : DbContext
    {
        public DbSet<User> Posts { get; set; }

        public UserContext() : base("UsertContext")
        {
        }

        public static UserContext Create()
        {
            return new UserContext();
        }
    }
}