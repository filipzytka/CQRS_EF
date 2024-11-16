namespace EntityFrameworkApp.Entities;

public class Department
{
    public int IdDepartment { get; set; }
    public string Address { get; set; } = string.Empty;
    public string DepartmentName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string MainMail { get; set; } = string.Empty;
    public string MainPhone { get; set; } = string.Empty;
    public string MainWww { get; set; } = string.Empty;
    public ICollection<UserDepartment> UserDepartments { get; set; } = null!;
}