using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EFDataAccessContext : DbContext, IDbContext
    {
        public IRepository<T> GetRepository<T>() where T : class, IEntity, new()
        {
            return new EFRepository<T>(Set<T>());
        }
    }
}
