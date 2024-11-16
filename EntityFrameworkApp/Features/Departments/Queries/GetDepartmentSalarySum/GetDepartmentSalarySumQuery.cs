using MediatR;

namespace EntityFrameworkApp.Features.Departments.Queries.GetDepartmentSalarySum;

public class GetDepartmentSalarySumQuery : IRequest<float>
{
    public int DepartmentId { get; }
    public int Year { get; }

    public GetDepartmentSalarySumQuery(int departmentId, int year)
    {
        DepartmentId = departmentId;
        Year = year;
    }
}
