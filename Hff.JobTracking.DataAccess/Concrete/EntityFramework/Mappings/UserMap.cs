using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.EMail).IsRequired();
            Property(p => p.Surname).IsRequired();
            Property(p => p.RoleId).IsRequired();
            Property(p => p.Password).IsRequired();
            HasMany(p => p.UserRoles).WithRequired(p => p.User).HasForeignKey(p => p.UserId);
            HasMany(p => p.UserWorks).WithRequired(prop => prop.User).HasForeignKey(p => p.UserId);
        }
    }
}
