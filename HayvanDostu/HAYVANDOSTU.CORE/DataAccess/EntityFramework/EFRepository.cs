using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using HayvanDostu.Core.DataAccess;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HayvanDostu.Core.DataAccess.EntityFramework;

namespace HayvanDostu.Core.DataAccess.EntityFramework
{
    public class EFRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IBaseEntity, new()
        where TContext : DbContext, new()
    {
        TContext context = EFSingletonContext<TContext>.Instance;

        public TEntity GetLastEntity()
        {
            return context.Set<TEntity>().Last();
        }
        public void Add(TEntity entity)
        {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
           
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
           
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            
                return context.Set<TEntity>().SingleOrDefault(filter);
           
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            
                if (filter == null)
                {
                    return context.Set<TEntity>().ToList();
                }
                else
                {
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            
        }

        public void Update(TEntity entity)
        {
            
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            
        }
    }
}
