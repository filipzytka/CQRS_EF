namespace EntityFrameworkApp.Entities;

public class UserDepartment
{
    public int UserId { get; set; }
    public int DepartmentId { get; set; }
    public User User { get; set; } = null!;
    public Department Department { get; set; } = null!;
}
