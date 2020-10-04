using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Concrete.Managers
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly IUrgencyDal _urgencyDal;
        public UrgencyManager(IUrgencyDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }
        public List<Urgency> GetUrgencies()
        {
            return _urgencyDal.GetList();
        }
    }
}
