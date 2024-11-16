using EntityFrameworkApp.Context;
using EntityFrameworkApp.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Features.Payments.Queries.GetAllPayments;

public class GetAllPaymentsQueryHandler : IRequestHandler<GetAllPaymentsQuery, IEnumerable<Payment>>
{
    private readonly MyAppContext _context;

    public GetAllPaymentsQueryHandler(MyAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Payment>> Handle(GetAllPaymentsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Payments.ToListAsync();
    }
}