using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Services.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        TEntity IRepository<TEntity>.Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
        void IRepository<TEntity>.Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
        void IRepository<TEntity>.Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        void IRepository<TEntity>.Remove(int id)
        {
            TEntity entity = Context.Set<TEntity>().Find(id);
            Context.Set<TEntity>().Remove(entity);
        }
        void IRepository<TEntity>.RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}