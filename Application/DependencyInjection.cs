using Application.Services;
using ConsoleApp1.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBaseService<Client>, ClientService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}