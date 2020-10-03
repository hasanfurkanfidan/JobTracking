using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.DependencyResolvers.Ninject
{
   public class NinjectFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
