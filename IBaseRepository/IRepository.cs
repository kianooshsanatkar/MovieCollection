using MovieCollection.Domain.CoreDomain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovieCollection.DataAccess.IBaseRepository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        TEntity Get(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity FindSingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
