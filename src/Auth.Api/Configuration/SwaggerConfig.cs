using Microsoft.OpenApi.Models;

namespace Auth.Api.Configuration;

public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "Auth Identity API",
                Description = "Esta API é responsável por fazer toda a gestão de Identitidade",
                Contact = new OpenApiContact() { Name = "Eduardo Carmo", Email = "ecsj.edu@gmail.com" },
            });

        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        });

        return app;
    }
}