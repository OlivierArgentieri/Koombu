using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace supinfo._3asp.koombu.Models
{
    public class Post
    {
        public int ID { get; set; }
        public int Like { get; set; }
       // public UserAccountViewModel Author { get; set; }
    }



    // Couche DAL 
    // todo Data Access Library
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public PostContext() : base("PostContext")
        {

        }

        public static PostContext Create()
        {
            return new PostContext();
        }
    }

    
}