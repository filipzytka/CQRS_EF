namespace EntityFrameworkApp.Contracts;

public record UserRequest(string FirstName, string LastName, string Username, string Password, string Description);