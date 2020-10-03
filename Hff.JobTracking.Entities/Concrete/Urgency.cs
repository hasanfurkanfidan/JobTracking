using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Concrete
{
   public class Urgency:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

       public List<Work> Works { get; set; }
    }
}
