using DevFramework.Core.Utilities.WebApi;
using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Concrete.Managers
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }
        public Report AddReport(Report report)
        {
            return MapperHelper.MapToSameType(_reportDal.Add(report));
        }

        public Report GetReport(Expression<Func<Report, bool>> filter)
        {
            return MapperHelper.MapToSameType(_reportDal.Get(filter));
        }
        //İf filter = null function get all the list
        public List<Report> GetReports(Expression<Func<Report, bool>> filter = null)
        {
            return MapperHelper.MapToSameType(_reportDal.GetList(filter));
        }
    }
}
