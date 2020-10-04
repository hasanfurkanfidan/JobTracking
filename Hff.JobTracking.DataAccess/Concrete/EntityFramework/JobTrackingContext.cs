using Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings;

using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework
{
   public class JobTrackingContext:DbContext
    {
        public JobTrackingContext():base("JobTrackingContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WorkMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UrgencyMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserWorkMap());

            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Report> Reports { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Urgency> Urgencies { get; set; }

        public DbSet<UserWork> UserWorks { get; set; }

        public DbSet<Work> Works { get; set; }
    }
}
