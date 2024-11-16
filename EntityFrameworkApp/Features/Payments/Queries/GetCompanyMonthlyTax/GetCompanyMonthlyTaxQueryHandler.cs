using EntityFrameworkApp.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Payments.Queries.GetCompanyMonthlyTax;

public class GetCompanyMonthlyTaxQueryHandler : IRequestHandler<GetCompanyMonthlyTaxQuery, float>
{
    private readonly MyAppContext _context;

    public GetCompanyMonthlyTaxQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<float> Handle(GetCompanyMonthlyTaxQuery query, CancellationToken cancellationToken)
    {
        return await _context.Payments
        .AsNoTracking()
        .Where(p => p.DateOfPayment.Month == query.Month && p.DateOfPayment.Year == query.Year)
        .Select(p => (p.Pay + p.Bonus) * query.TaxPercentage / 100)
        .SumAsync(cancellationToken);
    }
}
