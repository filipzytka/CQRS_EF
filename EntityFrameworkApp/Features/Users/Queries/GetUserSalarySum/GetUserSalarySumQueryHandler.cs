using EntityFrameworkApp.Context;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Users.Queries.GetUserSalarySum;

public class GetUserSalarySumQueryHandler
{
    private readonly MyAppContext _context;

    public GetUserSalarySumQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<float> Handle(GetUserSalarySumQuery query, CancellationToken cancellationToken)
    {
        return await _context.Users
            .AsNoTracking()
            .Where(u => u.FirstName == query.FirstName &&
            u.LastName == query.LastName)
            .SelectMany(u => u.Payments)
            .Where(p => p.DateOfPayment.Year == query.Year)
            .SumAsync(p => p.Pay + p.Bonus, cancellationToken);
    }
}
