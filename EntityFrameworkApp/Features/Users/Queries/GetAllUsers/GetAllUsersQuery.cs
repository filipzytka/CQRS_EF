using EntityFrameworkApp.Entities;
using MediatR;

namespace EntityFrameworkApp.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQuery : IRequest<IEnumerable<User>> { }
