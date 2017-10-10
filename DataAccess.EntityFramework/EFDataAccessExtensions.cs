using Microsoft.Extensions.DependencyInjection;
using System;

namespace DataAccess.EntityFramework
{
    public static class EFDataAccessExtensions
    {
        public static IDataAccessBuilder UseEntityFramework<T>(this IDataAccessBuilder builder)
            where T : EFDataAccessContext
        {
            if (builder == null)
            {
                ExceptionsHelper.ArgumentNullException(nameof(builder));
            }

            builder.Services.AddScoped<IDbContext, T>();
            return builder;
        }

        public static IDataAccessBuilder UseEntityFramework<T>(this IDataAccessBuilder builder,
            Func<IServiceProvider, T> implementationFactory)
            where T : EFDataAccessContext
        {
            if (builder == null)
            {
                ExceptionsHelper.ArgumentNullException(nameof(builder));
            }
            if (implementationFactory == null)
            {
                ExceptionsHelper.ArgumentNullException(nameof(implementationFactory));
            }

            builder.Services.AddScoped<IDbContext, T>(implementationFactory);
            return builder;
        }
    }
}
