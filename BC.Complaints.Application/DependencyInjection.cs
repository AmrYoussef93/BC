using BC.Complaints.Application.Services.Implementations;
using BC.Complaints.Application.Services.Interfaces;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Exceptions;
using System.Reflection;

namespace BC.Complaints.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            #region Services
            services.AddScoped<IStudentService, StudentService>();
            #endregion

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            var _logger = new LoggerConfiguration()
                              .Enrich.WithExceptionDetails()
                              .ReadFrom.Configuration(configuration)
                              .CreateLogger();
            services.AddSingleton<ILogger>(_logger);
            return services;
        }
    }
}
