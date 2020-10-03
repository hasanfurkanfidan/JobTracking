using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity> : IQueryableRepository<TEntity> where TEntity : class, IEntity, new()
       
    {
        private readonly DbContext _context;
        IDbSet<TEntity> _entities;
        public EfQueryableRepository(DbContext context)
        {
            
            _context = context;
        }
        public IQueryable<TEntity> Table => this.Entities;

        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<TEntity>();
                }
                return _entities;
            }
        }
    }
}
