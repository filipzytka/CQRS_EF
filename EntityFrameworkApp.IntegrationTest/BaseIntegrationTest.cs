using EntityFrameworkApp.Context;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkApp.Test;

public abstract class BaseIntegrationTest : IClassFixture<IntegrationTestWebAppFactory>, IAsyncLifetime
{
    private IDbContextTransaction _transaction = null!;
    private readonly IServiceScope _scope;

    protected readonly ISender Sender;
    protected readonly MyAppContext Context;

    protected BaseIntegrationTest(IntegrationTestWebAppFactory factory)
    {
        _scope = factory.Services.CreateScope();

        Context = _scope.ServiceProvider.GetRequiredService<MyAppContext>();
        Sender = _scope.ServiceProvider.GetRequiredService<ISender>();
    }

    public async Task InitializeAsync()
    {
        _transaction = await Context.Database.BeginTransactionAsync();
    }

    public async Task DisposeAsync()
    {
        await _transaction.RollbackAsync();
        await _transaction.DisposeAsync();
    }
}
