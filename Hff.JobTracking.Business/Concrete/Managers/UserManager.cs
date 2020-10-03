using AutoMapper;
using DevFramework.Core.Utilities.WebApi;
using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByEmailAndPassword(string email, string password)
        {
            return MapperHelper.MapToSameType(_userDal.Get(p => p.EMail == email && p.Password == password));
        }

        public List<ComplexUserRole> GetUserRoles(User user)
        {
            return MapperHelper.MapToSameType(_userDal.GetUserRoles(user));
        }
    }
}
