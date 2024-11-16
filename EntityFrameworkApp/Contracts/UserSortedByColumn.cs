namespace EntityFrameworkApp.Contracts;

public record UserSortedByColumn(string FirstName, string LastName, string Username, string Password, string Description, IEnumerable<string> Departments);