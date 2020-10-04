using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Abstract
{
    public interface IUrgencyService
    {
        List<Urgency> GetUrgencies();

        
    }
}
