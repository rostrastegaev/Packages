using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessExtensions
    {
        public static IDataAccessBuilder AddDataAccess(this IServiceCollection services)
        {
            if (services == null)
            {
                ExceptionsHelper.ArgumentNullException(nameof(services));
            }

            return new DataAccessBuilder(services);
        }
    }
}
