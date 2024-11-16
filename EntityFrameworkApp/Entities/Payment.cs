namespace EntityFrameworkApp.Entities;

public class Payment
{
    public int IdPayment { get; set; }
    public float Bonus { get; set; }
    public DateTime DateOfPayment { get; set; }
    public int IdUser { get; set; }
    public float Pay { get; set; }
    public User User { get; set; } = null!;
}