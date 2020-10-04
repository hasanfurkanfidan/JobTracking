using Hff.JobTracking.Business.Abstract;
using Hff.JobTracking.Business.Concrete.Managers;
using Hff.JobTracking.DataAccess.Abstract;
using Hff.JobTracking.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<UserDal>().InSingletonScope();
            Bind<IRoleService>().To<RoleManager>();
            Bind<IRoleDal>().To<RoleDal>().InSingletonScope();
            Bind<IWorkService>().To<IWorkService>();
            Bind<IWorkDal>().To<WorkDal>().InSingletonScope();

        }
    }
}
