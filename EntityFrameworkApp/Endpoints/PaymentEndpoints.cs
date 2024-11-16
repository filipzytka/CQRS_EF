using EntityFrameworkApp.Features.Payments.Queries.GetAllPayments;
using EntityFrameworkApp.Features.Payments.Queries.GetCompanyMonthlyTax;
using MediatR;

namespace EntityFrameworkApp.Endpoints;

public static class PaymentEndpoints
{
    public static void RegisterPaymentEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("api/payments", async (ISender sender) =>
        {
            var payments = await sender.Send(new GetAllPaymentsQuery());

            return Results.Ok(payments);
        })
        .WithOpenApi();

        app.MapGet("api/payments/monthly/tax", async (ISender sender, float taxPercentage, int month, int year) =>
        {
            var monthlyTax = await sender.Send(new GetCompanyMonthlyTaxQuery(taxPercentage, month, year));

            return Results.Ok(monthlyTax);
        })
        .WithOpenApi();
    }
}
