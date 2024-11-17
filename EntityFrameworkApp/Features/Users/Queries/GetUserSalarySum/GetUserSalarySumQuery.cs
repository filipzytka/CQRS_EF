using MediatR;

namespace EntityFrameworkApp.Users.Queries.GetUserSalarySum;

public class GetUserSalarySumQuery : IRequest<float>
{
    public int Year { get; }
    public string FirstName { get; } = string.Empty;
    public string LastName { get; } = string.Empty;

    public GetUserSalarySumQuery(int year, string firstName, string lastName)
    {
        Year = year;
        FirstName = firstName;
        LastName = lastName;
    }
}
