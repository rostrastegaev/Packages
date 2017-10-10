using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<T> Get(int id);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Select(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Select();
        void Delete(int id);
        void Delete(T entity);
        void Delete(IEnumerable<int> ids);
        void Delete(IEnumerable<T> entities);
        void Add(T entity);
        void Add(IEnumerable<T> entitites);
        void Update(T entity);
        void Update(IEnumerable<T> entities);

        IIncludedRepository<T> Include<TProp>(Expression<Func<T, TProp>> property);
    }
}
