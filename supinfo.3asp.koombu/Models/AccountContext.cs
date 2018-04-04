using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace supinfo._3asp.koombu.Models
{
    public class AccountContext : DbContext
    {
        
        public DbSet<UserAccountViewModel> UserAccounts { get; set; }

        public AccountContext() : base("DefaultConnection")
        {
            
        }
    }
}