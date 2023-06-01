using ApiWorkflow.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiWorkflow.Infrastructure
{
    public static class ConfigurationExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            //in real project, connection string should be kept in secret manager
            //this proj is only for demo
            services.AddDbContext<NumberContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LocalConnection")));

            return services;
        }
    }
}
