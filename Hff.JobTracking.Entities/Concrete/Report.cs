using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Concrete
{
   public class Report:IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int WorkId { get; set; }

        public Work Work { get; set; }


    }
}
