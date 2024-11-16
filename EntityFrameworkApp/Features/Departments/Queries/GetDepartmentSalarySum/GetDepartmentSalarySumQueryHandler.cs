using EntityFrameworkApp.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Departments.Queries.GetDepartmentSalarySum;

public class GetDepartmentSalarySumQueryHandler : IRequestHandler<GetDepartmentSalarySumQuery, float>
{
    private readonly MyAppContext _context;

    public GetDepartmentSalarySumQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<float> Handle(GetDepartmentSalarySumQuery query, CancellationToken cancellationToken)
    {
        return await _context.Users
            .AsNoTracking()
            .Where(u => u.UserDepartments
            .Any(d => d.DepartmentId == query.DepartmentId))
            .SelectMany(u => u.Payments)
            .Where(p => p.DateOfPayment.Year == query.Year)
            .SumAsync(p => p.Pay, cancellationToken);
    }
}
