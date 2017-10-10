using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFIncludedRepository<T> : IIncludedRepository<T> where T : class, IEntity, new()
    {
        private IRepository<T> _repo;
        private IQueryable<T> _set;

        public EFIncludedRepository(IRepository<T> repo, IQueryable<T> set)
        {
            _repo = repo;
            _set = set;
        }

        public void Add(T entity)
        {
            _repo.Add(entity);
        }

        public void Add(IEnumerable<T> entitites)
        {
            _repo.Add(entitites);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public void Delete(T entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(IEnumerable<int> ids)
        {
            _repo.Delete(ids);
        }

        public void Delete(IEnumerable<T> entities)
        {
            _repo.Delete(entities);
        }

        public async Task<T> Get(int id) =>
            await _set.FirstOrDefaultAsync(e => e.Id == id);

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
            _repo.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            _repo.Update(entities);
        }
    }
}
