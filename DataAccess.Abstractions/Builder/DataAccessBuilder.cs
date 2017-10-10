using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    internal class DataAccessBuilder : IDataAccessBuilder
    {
        public IServiceCollection Services { get; }

        public DataAccessBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}
