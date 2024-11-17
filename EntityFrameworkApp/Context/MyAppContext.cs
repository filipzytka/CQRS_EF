using EntityFrameworkApp.Entities;
using EntityFrameworkApp.Seeder;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Context;

public class MyAppContext(DbContextOptions<MyAppContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<UserDepartment> UserDepartments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>().HasKey(u => u.IdUser);
        builder.Entity<Department>().HasKey(d => d.IdDepartment);
        builder.Entity<Payment>().HasKey(d => d.IdPayment);

        builder.Entity<UserDepartment>()
            .HasKey(ud => new { ud.UserId, ud.DepartmentId });

        builder.Entity<User>()
            .HasMany(u => u.UserDepartments)
            .WithOne(ud => ud.User)
            .HasForeignKey(ud => ud.UserId);

        builder.Entity<Payment>()
            .HasOne(u => u.User)
            .WithMany(p => p.Payments)
            .HasForeignKey(p => p.IdUser);

        builder.Entity<Department>()
            .HasMany(d => d.UserDepartments)
            .WithOne(ud => ud.Department)
            .HasForeignKey(ud => ud.DepartmentId);

        builder.SeedUsers();
        builder.SeedDepartments();
        builder.SeedUserDepartments();
        builder.SeedPayments();
    }
}