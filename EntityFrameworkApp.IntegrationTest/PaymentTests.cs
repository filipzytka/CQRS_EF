using EntityFrameworkApp.Features.Payments.Queries.GetAllPayments;
using EntityFrameworkApp.Features.Payments.Queries.GetCompanyMonthlyTax;
using FluentAssertions;

namespace EntityFrameworkApp.Test;

public class PaymentTests : BaseIntegrationTest
{
    public PaymentTests(IntegrationTestWebAppFactory factory) : base(factory) { }

    [Fact]
    public async Task WhenAllPaymentsAreFetched_ThenAllPaymentsAreReturned()
    {
        var query = new GetAllPaymentsQuery();

        var payments = await Sender.Send(query);

        payments.Count.Should().Be(6);
    }

    [Fact]
    public async Task WhenMonthlyTaxAndDateAreProvided_ThenMonthlyTaxValueIsReturned()
    {
        var query = new GetCompanyMonthlyTaxQuery(10, 3, 2024);

        var tax = await Sender.Send(query);

        tax.Should().Be(280);
    }
}
