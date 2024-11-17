using EntityFrameworkApp.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Testcontainers.PostgreSql;

namespace EntityFrameworkApp.Test;

public class IntegrationTestWebAppFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private PostgreSqlContainer _container = new PostgreSqlBuilder()
            .WithImage("postgres:17")
            .Build();

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            var descriptor = services.SingleOrDefault(s => s.ServiceType == typeof(DbContextOptions<MyAppContext>));

            if (descriptor is not null)
            {
                services.Remove(descriptor);
            }

            services.AddDbContext<MyAppContext>(options =>
            options.UseNpgsql(_container.GetConnectionString()));
        });
    }

    public Task InitializeAsync()
    {
        return _container.StartAsync();
    }

    public new Task DisposeAsync()
    {
        return _container.StopAsync();
    }
}
