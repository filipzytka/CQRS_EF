using EntityFrameworkApp.Features.Departments.Queries.GetAllDepartments;
using EntityFrameworkApp.Features.Departments.Queries.GetDepartmentSalarySum;
using MediatR;

namespace EntityFrameworkApp.Endpoints;

public static class DepartmentEndpoints
{
    public static void RegisterDepartmentEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("api/departments", async (ISender sender) =>
        {
            var departments = await sender.Send(new GetAllDepartmentsQuery());

            return Results.Ok(departments);
        });

        app.MapGet("api/departments/{departmentId}/salaries/sum", async (ISender sender, int departmentId, int year) =>
        {
            var salarySum = await sender.Send(new GetDepartmentSalarySumQuery(departmentId, year));

            return Results.Ok(salarySum);
        })
        .WithOpenApi();
    }
}