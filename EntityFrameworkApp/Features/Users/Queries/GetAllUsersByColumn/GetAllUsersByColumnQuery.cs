using EntityFrameworkApp.Contracts;
using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsersByColumn;

public class GetAllUsersByColumnQuery : IRequest<IEnumerable<UserSortedByColumn>>
{
    public string Column { get; } = string.Empty;

    public GetAllUsersByColumnQuery(string column)
    {
        Column = column;
    }
}
