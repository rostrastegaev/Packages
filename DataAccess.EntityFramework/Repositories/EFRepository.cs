using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private DbSet<T> _set;

        public EFRepository(DbSet<T> set)
        {
            _set = set;
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void Add(IEnumerable<T> entitites)
        {
            _set.AddRange(entitites);
        }

        public void Delete(int id)
        {
            _set.Attach(new T { Id = id }).State = EntityState.Deleted;
        }

        public void Delete(T entity)
        {
            _set.Attach(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<int> ids)
        {
            if (ids == null)
                return;

            foreach (var id in ids)
            {
                Delete(id);
            }
        }

        public void Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                return;

            foreach (var entity in entities)
            {
                Delete(entity);
            }
        }

        public async Task<T> Get(int id) =>
            await _set.FindAsync(id);

        public async Task<T> Get(Expression<Func<T, bool>> predicate) =>
            await _set.FirstOrDefaultAsync(predicate);

        public IIncludedRepository<T> Include<TProp>(Expression<Func<T, TProp>> property) =>
            new EFIncludedRepository<T>(this, _set.Include(property));

        public async Task<IEnumerable<T>> Select(Expression<Func<T, bool>> predicate) =>
            await _set.Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> Select() =>
            await _set.ToListAsync();

        public void Update(T entity)
        {
            _set.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            _set.UpdateRange(entities);
        }
    }
}
