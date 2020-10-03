using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
   public class RoleMap:EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired();
            
        }
    }
}
