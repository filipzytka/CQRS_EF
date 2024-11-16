using System;
using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Departments.Queries.GetAllDepartmentsByColumn;

public class GetAllDepartmentsByColumnQueryHandler : IRequestHandler<GetAllDepartmentsByColumnQuery, IEnumerable<Department>>
{
    private readonly MyAppContext _context;

    public GetAllDepartmentsByColumnQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Department>> Handle(GetAllDepartmentsByColumnQuery request, CancellationToken cancellationToken)
    {
        return await _context.Departments
            .OrderBy(d => EF.Property<object>(d, request.Column))
            .ToListAsync(cancellationToken);
    }
}
