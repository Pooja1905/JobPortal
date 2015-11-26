using JobPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobPortal.Entities
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=JobPortalConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
       
       
    }

    public class UserInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {

    }
}