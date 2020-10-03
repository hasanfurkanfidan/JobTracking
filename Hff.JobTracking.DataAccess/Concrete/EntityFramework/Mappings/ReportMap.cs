using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework.Mappings
{
  public  class ReportMap:EntityTypeConfiguration<Report>
    {
        public ReportMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Description).IsRequired();
            HasRequired(p => p.Work).WithMany(p => p.Reports).HasForeignKey(p => p.WorkId);
        }
    }
}
