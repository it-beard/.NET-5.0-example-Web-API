using Itbeard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Itbeard.Web.AppStart
{
    public static class DatabaseContextServiceExtension
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(connectionString));
        }
    }
}