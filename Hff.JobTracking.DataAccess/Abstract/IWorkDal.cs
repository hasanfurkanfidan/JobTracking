using DevFramework.Core.DataAccess;
using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Abstract
{
   public interface IWorkDal:IEntityRepository<Work>
    {
         List<ComplexUserWorks> GetUserWorks(User user);
    }
}
