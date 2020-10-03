using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Entities.Dtos
{
   public class UserLoginDto:IDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
