using EntityFrameworkApp.Contracts;
using EntityFrameworkApp.Features.Users.Commands.AddUser;
using EntityFrameworkApp.Features.Users.Queries.GetAllUsers;
using EntityFrameworkApp.Features.Users.Queries.GetAllUsersByColumn;
using EntityFrameworkApp.Users.Queries.GetUserSalarySum;
using FluentAssertions;

namespace EntityFrameworkApp.Test;

public class UserTests : BaseIntegrationTest
{
    public UserTests(IntegrationTestWebAppFactory factory) : base(factory) { }

    [Fact]
    public async Task WhenUserIsAdded_ThenUserExistsInDb()
    {
        var user = new UserRequest("TestJohn", "Doe", "John1@3", "qwerty", "");
        var command = new AddUserCommand(user);

        var userId = await Sender.Send(command);

        var newUser = Context.Users.First(u => u.IdUser == userId);
        Context.Users.Should().Contain(newUser);
    }

    [Fact]
    public async Task WhenAllUsersAreRequested_ThenAllUsersAreReturned()
    {
        var query = new GetAllUsersQuery();

        var users = await Sender.Send(query);

        users.Count.Should().Be(10);
    }

    [Fact]
    public async Task WhenColumnNameIsProvided_ThenUsersAreOrderedByColumnName()
    {
        var columnName = "FirstName";
        var query = new GetAllUsersByColumnQuery(columnName);

        var usersOrderedByColumn = await Sender.Send(query);

        var expectedFirstName = "Anna";
        usersOrderedByColumn.ElementAt(0).FirstName.Should().Be(expectedFirstName);
    }

    [Fact]
    public async Task WhenUserSalarySumForGivenYearIsRequested_ThenSalarySumIsReturned()
    {
        var query = new GetUserSalarySumQuery(2020, "Maria", "Garcia");

        var sum = await Sender.Send(query);

        sum.Should().Be(9100f);
    }
}
