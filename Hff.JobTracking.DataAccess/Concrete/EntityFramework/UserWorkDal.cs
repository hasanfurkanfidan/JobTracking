using DevFramework.Core.DataAccess.EntityFramework;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework
{
    public class UserWorkDal : EfEntityRepositoryBase<UserWork, JobTrackingContext>, IUserWorkDal
    {
      
    }
}
