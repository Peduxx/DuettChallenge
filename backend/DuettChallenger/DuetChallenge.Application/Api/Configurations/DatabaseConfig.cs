using DuettChallenge.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<DuettChallengeDbContext>(
                options => options.UseSqlite(configuration.GetConnectionString("core")));
        }
    }
}
