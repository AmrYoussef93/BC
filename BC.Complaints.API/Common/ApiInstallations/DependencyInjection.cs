using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace BC.Complaints.API.Common.ApiInstallations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(pol =>
                {
                    pol.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            services.AddControllers()
                    .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<Startup>()); ;
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BC.Complaints.API", Version = "v1" });
            });
            return services;
        }
    }
}
