using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Concrete
{
   public class UserWork:IEntity
    {
        public int Id { get; set; }

        public Work Work { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public int WorkId { get; set; }

    }
}
