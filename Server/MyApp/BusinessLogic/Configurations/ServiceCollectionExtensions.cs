using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using BusinessLogic.Validators;
using DataAccess.Configurations;
using Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Models;

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
            services.AddTransient<IConcertViewLogic, ConcertViewLogic>();
            services.AddTransient<IValidator<ConcertDto>, ConcertValidation>();
            services.AddTransient<IValidator<SingerDto>, SingerValidation>();
            services.AddTransient<IValidator<LocationDto>, LocationValidation>();





        }
    }
}
