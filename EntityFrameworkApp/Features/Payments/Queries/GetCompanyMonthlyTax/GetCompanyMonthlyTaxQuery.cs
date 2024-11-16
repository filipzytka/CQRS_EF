using MediatR;

namespace EntityFrameworkApp.Features.Payments.Queries.GetCompanyMonthlyTax;

public class GetCompanyMonthlyTaxQuery : IRequest<float>
{
    public float TaxPercentage { get; }
    public int Month { get; }
    public int Year { get; }

    public GetCompanyMonthlyTaxQuery(float taxPercentage, int month, int year)
    {
        TaxPercentage = taxPercentage;
        Month = month;
        Year = year;
    }
}
