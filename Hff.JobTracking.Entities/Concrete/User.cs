using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Concrete
{
   public class User:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string EMail { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public List<UserRole> UserRoles { get; set; }

        public List<UserWork> UserWorks { get; set; }
    }
}
