using EntityFrameworkApp.Context;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp;

public static class DependencyInjection
{
    public static void AddDatabase(this IServiceCollection services)
    {
        var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        services.AddDbContext<MyAppContext>(options => options.UseNpgsql(connectionString));
    }

    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<MyAppContext>();

        var pendingMigrations = context.Database.GetPendingMigrations();
        if (pendingMigrations.Any())
        {
            context.Database.Migrate();
        }
    }
}