using Hff.JobTracking.Entities.ComplexTypes;
using Hff.JobTracking.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JobTracking.Business.Abstract
{
   public interface IWorkService
    {
        //Görev ekleme

        Work AddWork(Work work);
        //Görev Atama 
        UserWork AssignWork(Work work,List< User> users);
        //Görevleri getirme 
        List<Work> GetWorks(Expression<Func<Work, bool>> filter=null);
        //Görevi Passive yapma şimdilik silme
        void DeleteWork(int id);
        //Görevi Tamamla
        Work WorkComplete(Work work);

        List<ComplexUserWorks> GetUserWorks(User user);
    }
}
