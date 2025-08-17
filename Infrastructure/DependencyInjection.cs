using Application.Interfaces.Infrastructure;
using Infrastructure.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmailService>(provider =>
                new SmtpEmailService(
                    configuration["Email:Host"]!,
                    int.Parse(configuration["Email:Port"]!),
                    configuration["Email:Username"]!,
                    configuration["Email:Password"]!,
                    configuration["Email:FromEmail"]!
                ));

            return services;
        }
    }

}
