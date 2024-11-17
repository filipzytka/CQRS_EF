using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, ICollection<User>>
{
    private readonly MyAppContext _context;

    public GetAllUsersQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<ICollection<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users.AsNoTracking().ToListAsync(cancellationToken);
    }
}
