using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Departments.Queries.GetAllDepartmentsByColumn;

public class GetAllDepartmentsByColumnQuery : IRequest<IEnumerable<Department>>
{
    public string Column { get; }

    public GetAllDepartmentsByColumnQuery(string column)
    {
        Column = column;
    }
}
