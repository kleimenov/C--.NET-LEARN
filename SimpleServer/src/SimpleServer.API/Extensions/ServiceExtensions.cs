// src/SimpleServer.API/Extensions/ServiceExtensions.cs
using SimpleServer.API.Interfaces;
using SimpleServer.API.Services;

namespace SimpleServer.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            
            return services;
        }
    }
}

// src/SimpleServer.API/Extensions/WebApplicationExtensions.cs
namespace SimpleServer.API.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplication ConfigureApplication(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}