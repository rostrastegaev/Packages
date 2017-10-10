using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public interface IDataAccessBuilder
    {
        IServiceCollection Services { get; }
    }
}
