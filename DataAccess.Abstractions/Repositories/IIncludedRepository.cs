namespace DataAccess
{
    public interface IIncludedRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
    }
}
