using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Configurations
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessLogic(this IServiceCollection services)
        {
            services.AddTransient<IConcertLogic, ConcertLogic>();
         
        }
    }
}
