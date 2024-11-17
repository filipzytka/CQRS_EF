using EntityFrameworkApp.Context;
using EntityFrameworkApp.Contracts;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsersByColumn;

public class GetAllUsersByColumnQueryHandler : IRequestHandler<GetAllUsersByColumnQuery, ICollection<UserSortedByColumn>>
{
    private readonly MyAppContext _context;

    public GetAllUsersByColumnQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<ICollection<UserSortedByColumn>> Handle(GetAllUsersByColumnQuery request, CancellationToken cancellationToken)
    {
        return await _context.Users
            .OrderBy(d => EF.Property<object>(d, request.Column))
            .Select(u => new UserSortedByColumn(u.IdUser, u.FirstName, u.LastName, u.Username, u.Password, u.Description, u.UserDepartments
                .Select(ud => ud.Department.DepartmentName)))
            .ToListAsync(cancellationToken);
    }
}
