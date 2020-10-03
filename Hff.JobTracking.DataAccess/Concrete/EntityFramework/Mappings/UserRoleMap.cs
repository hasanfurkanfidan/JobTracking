using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
   public class UserRoleMap:EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            HasKey(p => p.Id);
            HasIndex(p => new { p.UserId, p.RoleId }).IsUnique();
            HasRequired(p => p.Role).WithMany(p => p.UserRoles).HasForeignKey(p => p.RoleId);
            HasRequired(p => p.User).WithMany(prop => prop.UserRoles).HasForeignKey(p => p.UserId);

        }
    }
}
