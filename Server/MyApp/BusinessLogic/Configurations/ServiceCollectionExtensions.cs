using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using DataAccess.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Configurations
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessLogic(this IServiceCollection services, string connectionString)
        {
            services.AddDataAccess(connectionString);
            services.AddTransient<IConcertLogic, ConcertLogic>();
            services.AddTransient<ILocationLogic, LocationLogic>();
            services.AddTransient<ISingerLogic, SingerLogic>();
            services.AddTransient<IConcertSingerLogic, ConcertSingerLogic>();



        }
    }
}
