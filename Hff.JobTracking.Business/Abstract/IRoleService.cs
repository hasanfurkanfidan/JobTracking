﻿using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Abstract
{
   public interface IRoleService
    {
        Role AddRole(Role role);

        Role UpdateRole(Role role);

        List<Role> GetRoles();

        Role GetRole(int id);

    }
}
