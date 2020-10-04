using AutoMapper;
using DevFramework.Core.Utilities.WebApi;
using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Concrete.Managers
{
   public class WorkManager:IWorkService
    {
        private readonly IWorkDal _workDal;
        private readonly IUserDal _userDal;
        private readonly IUserWorkDal _userWorkDal;
        public WorkManager(IWorkDal _workDal,IUserDal _userDal,IUserWorkDal userWorkDal)
        {
            _workDal = this._workDal;
            _userDal = this._userDal;
            _userWorkDal = userWorkDal;
        }

        public Work AddWork(Work work)
        {
            throw new NotImplementedException();
        }

        public UserWork AssignWork(Work work,List< User> users)
        {
            var userWork = new UserWork();
            foreach (var user in users)
            {
                work.StateId = Convert.ToInt32(Work.State.New);
                userWork.UserId = user.Id;
                userWork.WorkId = work.Id;

                _userWorkDal.Add(MapperHelper.MapToSameType(_userWorkDal.Add(userWork)));
                   

              
            }
          return  MapperHelper.MapToSameType(userWork);
        
        }

        public void DeleteWork(int id)
        {
          var work =   _workDal.Get(p => p.Id == id);
            _workDal.Delete(work);
        }

        public List<ComplexUserWorks> GetUserWorks(User user)
        {
            return MapperHelper.MapToSameType( _workDal.GetUserWorks(user));
        }

        public List<Work> GetWorks(Expression<Func<Work, bool>> filter = null)
        {
          return MapperHelper.MapToSameType(_workDal.GetList(filter));
        }

        public Work WorkComplete(Work work)
        {
            work.StateId = Convert.ToInt32(Work.State.Completed);
            return work;
        }
    }
}
