using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace supinfo._3asp.koombu.Models
{
    public class UserContext : DbContext
    {
        
        public DbSet<UserModel> Users { get; set; }

        public UserContext() : base("DefaultConnection")
        {
            
        }
    }
}