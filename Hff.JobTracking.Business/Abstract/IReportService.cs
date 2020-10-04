using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Abstract
{
   public interface IReportService
    {
        Report AddReport(Report report);

        Report GetReport(Expression<Func<Report, bool>>filter);

        List<Report> GetReports(Expression<Func<Report,bool>>filter=null);

    }
}
