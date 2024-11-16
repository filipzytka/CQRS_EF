using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Testcontainers.PostgreSql;

namespace EntityFrameworkApp.Test;

public class DatabaseTests : IAsyncLifetime
{
    private MyAppContext Context { get; set; } = null!;
    private PostgreSqlContainer Container { get; set; } = null!;

    public async Task InitializeAsync()
    {
        Container = new PostgreSqlBuilder()
            .Build();

        await Container.StartAsync();

        Context = new MyAppContext(new DbContextOptionsBuilder<MyAppContext>()
            .UseNpgsql(Container.GetConnectionString()).Options);

        await Context.Database.MigrateAsync();
    }

    public async Task DisposeAsync()
    {
        await Context.DisposeAsync();
        await Container.StopAsync();
    }

    [Fact]
    public async Task WhenUserIsAdded_ThenUserExistsInDb()
    {
        var newUser = await AddTestUser();

        Context.Users.Should().Contain(newUser);
    }

    [Fact]
    public async Task WhenUserIsRemoved_ThenUserDoesNotExistInDb()
    {
        var newUser = await AddTestUser();

        Context.Remove(newUser);
        await Context.SaveChangesAsync();

        Context.Users.Should().NotContain(newUser);
    }

    [Fact]
    public async Task WhenUserPropertyIsChanged_ThenUserIsModified()
    {
        var user = await AddTestUser();

        user.Username = "NewUserName";

        Context.Update(user);
        await Context.SaveChangesAsync();

        Context.Users.Should().Contain(u => u.Username == user.Username);
    }

    private async Task<User> AddTestUser()
    {
        var userToRemove = new User
        {
            FirstName = "Jan",
            LastName = "Kowalski",
            Description = "Opis",
            Password = "123",
            Username = "Januszxx",
            Departments = new List<Department>(),
            Payments = new List<Payment>()
        };
        Context.Add(userToRemove);
        await Context.SaveChangesAsync();

        return userToRemove;
    }
}