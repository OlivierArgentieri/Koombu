using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace supinfo._3asp.koombu.Models
{
    public class AccountContext : DbContext
    {
        
        public DbSet<UserAccount> UserAccounts { get; set; }

        public AccountContext() : base("DefaultConnection")
        {
            
        }
    }
}