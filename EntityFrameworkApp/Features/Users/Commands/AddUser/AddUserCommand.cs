using EntityFrameworkApp.Contracts;
using MediatR;

namespace EntityFrameworkApp.Features.Users.Commands.AddUser;

public class AddUserCommand : IRequest<int>
{
    public UserRequest UserRequest { get; set; } = null!;
}
