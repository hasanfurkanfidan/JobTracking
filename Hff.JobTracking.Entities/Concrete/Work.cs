using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Concrete
{
    public class Work : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Datetime { get; set; }
        public int ReportId { get; set; }
        public int UrgencyId { get; set; }

        public int StateId { get; set; }
        public Urgency Urgency { get; set; }

        public List<UserWork> UserWorks { get; set; }
        public List<Report> Reports { get; set; }


       public enum State
        {
            New=0,Completed=1,Pending=2,WontCpmplete=3
        }
    }
}
