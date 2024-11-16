using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Users.Commands.AddUser;

public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
{
    private readonly MyAppContext _context;

    public AddUserCommandHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User()
        {
            FirstName = request.UserRequest.FirstName,
            LastName = request.UserRequest.LastName,
            Username = request.UserRequest.Username,
            Password = request.UserRequest.Password,
            Description = request.UserRequest.Description
        };

        _context.Add(user);
        await _context.SaveChangesAsync(cancellationToken);

        return user.IdUser;
    }
}
