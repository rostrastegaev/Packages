namespace DataAccess
{
    public interface IDbContext
    {
        IRepository<T> GetRepository<T>() where T : class, IEntity, new();
        int SaveChanges();
    }
}
