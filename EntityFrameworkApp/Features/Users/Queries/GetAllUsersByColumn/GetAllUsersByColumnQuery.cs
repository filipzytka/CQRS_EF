using EntityFrameworkApp.Contracts;
using MediatR;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsersByColumn;

public class GetAllUsersByColumnQuery : IRequest<ICollection<UserSortedByColumn>>
{
    public string Column { get; } = string.Empty;

    public GetAllUsersByColumnQuery(string column)
    {
        Column = column;
    }
}
