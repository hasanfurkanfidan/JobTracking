using DevFramework.Core.DataAccess.EntityFramework;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework
{
    public class WorkDal : EfEntityRepositoryBase<Work, JobTrackingContext>, IWorkDal
    {
        public List<ComplexUserWorks> GetUserWorks(User user)
        {
            using (var context = new JobTrackingContext())
            {
                var result = from work in context.Works
                             join userworks in context.UserWorks
                             on work.Id equals userworks.WorkId
                             join urgency in context.Urgencies
                             on work.UrgencyId equals urgency.Id
                             where userworks.UserId == user.Id
                             select new ComplexUserWorks
                             {
                                 Works = work
                             };

                return result.ToList();

            }
        }
    }
}
