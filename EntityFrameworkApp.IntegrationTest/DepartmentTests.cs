using EntityFrameworkApp.Features.Departments.Queries.GetDepartmentSalarySum;
using FluentAssertions;

namespace EntityFrameworkApp.Test;

public class DepartmentTests : BaseIntegrationTest
{
    public DepartmentTests(IntegrationTestWebAppFactory factory) : base(factory) { }

    [Fact]
    public async Task WhenDepartmentSalarySumIsFetched_ThenSalarySumIsReturned()
    {
        var query = new GetDepartmentSalarySumQuery(2, 2020);

        var sum = await Sender.Send(query);

        sum.Should().Be(8400);
    }
}
