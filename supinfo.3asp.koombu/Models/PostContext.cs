using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace supinfo._3asp.koombu.Models
{
    public class PostUserContext : DbContext
    {
        public DbSet<PostViewModel> PostsUserAccount { get; set; }

        public PostUserContext() : base("DefaultConnection")
        {

        }
    }
}