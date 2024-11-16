namespace EntityFrameworkApp.Entities;

public class User
{
    public int IdUser { get; set; }
    public string Description { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public IEnumerable<Payment> Payments { get; set; } = null!;
    public ICollection<UserDepartment> UserDepartments { get; set; } = null!;
}