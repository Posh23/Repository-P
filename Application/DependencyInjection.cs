using Application.Services;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IBaseService<Client>, ClientService>();
        services.AddScoped<IBaseService<Equipment>, EquipmentService>();
        services.AddScoped<IBaseService<Magazine>, MagazineService>();
        services.AddScoped<IBaseService<Payment>, PaymentService>();
        services.AddScoped<IBaseService<Photographer>, PhotographerService>();
        services.AddScoped<IBaseService<PhotoSession>, PhotoSessionService>();
        services.AddScoped<IBaseService<Staff>, StaffService>();
        services.AddScoped<IBaseService<Studio>, StudioService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}