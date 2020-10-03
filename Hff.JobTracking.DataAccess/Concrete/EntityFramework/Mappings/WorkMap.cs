using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
   public class WorkMap:EntityTypeConfiguration<Work>
    {
        public WorkMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired();
            Property(p => p.UrgencyId).IsRequired();
            HasRequired(p => p.Urgency).WithMany(p => p.Works).HasForeignKey(p => p.UrgencyId);
        }
    }
}
