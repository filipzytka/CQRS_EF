using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
{
    private readonly MyAppContext _context;

    public GetAllUsersQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users.AsNoTracking().ToListAsync(cancellationToken);
    }
}
