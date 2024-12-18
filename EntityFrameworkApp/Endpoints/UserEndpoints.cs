using EntityFrameworkApp.Features.Users.Commands.AddUser;
using EntityFrameworkApp.Features.Users.Queries.GetAllUsers;
using EntityFrameworkApp.Features.Users.Queries.GetAllUsersByColumn;
using MediatR;

namespace EntityFrameworkApp.Endpoints;

public static class UserEndpoints
{
    public static void RegisterUserEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("api/users", async (ISender sender, AddUserCommand command) =>
        {
            var userId = await sender.Send(command);

            return Results.Ok(userId);
        })
        .WithOpenApi();

        app.MapGet("api/users/{column}", async (ISender sender, string column) =>
        {
            var usersByColumn = await sender.Send(new GetAllUsersByColumnQuery(column));

            return Results.Ok(usersByColumn);
        });

        app.MapGet("api/users", async (ISender sender) =>
        {
            var users = await sender.Send(new GetAllUsersQuery());

            return Results.Ok(users);
        })
        .WithOpenApi();
    }
}
