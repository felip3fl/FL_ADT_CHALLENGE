using Adt.Challenge.Business.Interfaces.Repositories;
using Adt.Challenge.Business.Interfaces.Services;
using Adt.Challenge.Business.Services;
using Adt.Challenge.Infra.Data.Repository.Crv;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Adt.Challenge.Api.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            #region INFRA
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            #endregion

            #region CORE
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IRestaurantService, RestaurantService>();
            #endregion

            return services;
        }
    }
}
