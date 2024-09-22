using System.Text.Json;

namespace WebApiTemplate.Api.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers().AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddApplicationServices();
        
        return services;
    }

    private static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        
        return services;
    }
}