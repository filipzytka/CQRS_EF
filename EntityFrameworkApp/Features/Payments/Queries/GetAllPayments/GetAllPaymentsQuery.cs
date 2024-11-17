using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Payments.Queries.GetAllPayments;

public class GetAllPaymentsQuery : IRequest<ICollection<Payment>> { }
