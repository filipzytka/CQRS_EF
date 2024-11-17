namespace EntityFrameworkApp.Contracts;

public record UserSortedByColumn(int Id, string FirstName, string LastName, string Username, string Password, string Description, IEnumerable<string> Departments);