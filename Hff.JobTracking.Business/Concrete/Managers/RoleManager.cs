using DevFramework.Core.Utilities.WebApi;
using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Concrete.Managers
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public Role AddRole(Role role)
        {
            return MapperHelper.MapToSameType(_roleDal.Add(role));
        }

        public Role GetRole(int id)
        {
            return MapperHelper.MapToSameType(_roleDal.Get(p => p.Id == id));
        }

        public List<Role> GetRoles()
        {
           var roles  = MapperHelper.MapToSameType(_roleDal.GetList());
            return roles;
        }

        public Role UpdateRole(Role role)
        {
            return MapperHelper.MapToSameType(_roleDal.Update(role));
        }
    }
}
