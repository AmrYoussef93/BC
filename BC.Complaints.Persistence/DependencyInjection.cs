using BC.Complaints.Application.Common.Interfaces;
using BC.Complaints.Persistence.Context;
using BC.Complaints.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BC.Complaints.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BankruptcyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BankruptcyDbContext")));
            services.AddScoped<DbContext, BankruptcyDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;

        }
    }

}
