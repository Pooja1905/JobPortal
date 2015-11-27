using JobPortal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobPortal.Data
{
    public class JobPortalContext : DbContext
    {
        public JobPortalContext()
            : base("JobPortalConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
       
       
    }

    public class UserInitializer : DropCreateDatabaseIfModelChanges<JobPortalContext>
    {

    }
}