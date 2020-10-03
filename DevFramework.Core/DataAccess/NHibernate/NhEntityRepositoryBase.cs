using DevFramework.Core.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly NHibernateHelper _nhiberNateHelper;
        public NhEntityRepositoryBase(NHibernateHelper nhiberNateHelper)
        {
            _nhiberNateHelper = nhiberNateHelper;
        }
        public TEntity Add(TEntity entity)
        {
            using (var session = _nhiberNateHelper.OpenSession())
            {
                session.Save(entity);
            }
            return entity;
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nhiberNateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nhiberNateHelper.OpenSession())
            {
                if (filter == null) { return session.Query<TEntity>().SingleOrDefault(); }
                return session.Query<TEntity>().Where(filter).SingleOrDefault();
                
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nhiberNateHelper.OpenSession())
            {
                if (filter == null) { return session.Query<TEntity>().ToList(); }
                return session.Query<TEntity>().Where(filter).ToList();
                
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nhiberNateHelper.OpenSession())
            {
                session.Update(entity);
            }
            return entity;
        }
    }
}
