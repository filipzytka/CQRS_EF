using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Departments.Queries.GetAllDepartments;

public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, IEnumerable<Department>>
{
    private readonly MyAppContext _context;

    public GetAllDepartmentsQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Department>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Departments.AsNoTracking().ToListAsync(cancellationToken);
    }
}
