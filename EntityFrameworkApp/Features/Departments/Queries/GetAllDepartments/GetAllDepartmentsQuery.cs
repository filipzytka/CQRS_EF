using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Departments.Queries.GetAllDepartments;

public class GetAllDepartmentsQuery : IRequest<IEnumerable<Department>> { }
