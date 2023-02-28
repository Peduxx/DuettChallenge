using DuettChallenge.Business.Ports;
using DuettChallenge.Business.Services;
using DuettChallenge.Business.Services.Interfaces;
using DuettChallenge.Data.DuettChallenger.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DuettChallenge.CrossCutting.DependencyInjection
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Bus
            services.AddScoped<IFruitsService, FruitsService>();

            // Data
            services.AddScoped<IFruitRepository, FruitsRepository>();
        }
    }
}
