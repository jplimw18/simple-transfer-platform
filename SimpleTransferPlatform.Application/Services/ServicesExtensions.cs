using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace SimpleTransferPlatform.Application.Services;

public static class ServicesExtensions
{
    public static void ConfigureApplicationApp(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        var validators = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => !t.IsAbstract && !t.IsInterface)
            .Select(t => new
            {
                ValidatorInterface = t.GetInterfaces()
                    .FirstOrDefault(i => i.IsGenericType &&
                                         i.GetGenericTypeDefinition() == typeof(IValidator<>)),
                Implementation = t
            })
            .Where(t => t.ValidatorInterface != null);

        foreach (var v in validators)
            services.AddTransient(v.ValidatorInterface!, v.Implementation);
    }
}