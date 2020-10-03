using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserWorkMap:EntityTypeConfiguration<UserWork>
    {
        public UserWorkMap()
        {
            HasKey(p => p.Id);
            HasIndex(p => new { p.WorkId, p.UserId }).IsUnique();
            HasRequired(p => p.Work).WithMany(prop => prop.UserWorks).HasForeignKey(p => p.WorkId);
            HasRequired(p => p.User).WithMany(prop => prop.UserWorks).HasForeignKey(p => p.UserId);
        }
    }
}
