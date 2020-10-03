using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepositoryBase<User, JobTrackingContext>, IUserDal
    {
        public List<ComplexUserRole> GetUserRoles(User user)
        {
            using (var context = new JobTrackingContext())
            {
                var result = from role in context.Roles
                             join userRole in context.UserRoles
                             on role.Id equals userRole.RoleId
                             where userRole.UserId == user.Id
                             select new ComplexUserRole
                             {
                                 RoleNmae = role.Name
                             };
                return result.ToList();


            }
        }
    }
}
