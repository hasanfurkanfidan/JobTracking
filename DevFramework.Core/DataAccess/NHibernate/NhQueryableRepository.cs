using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private readonly NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public NhQueryableRepository(NHibernateHelper nhiberNateHelper)
        {
            _nHibernateHelper = nhiberNateHelper;
        }
        public IQueryable<T> Table { get { return this.Entities; } }

        protected virtual IQueryable<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    var session = _nHibernateHelper.OpenSession();
                    _entities = session.Query<T>();

                }
                return _entities;
            }
        }
    }
}
