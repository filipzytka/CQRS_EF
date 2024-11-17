using EntityFrameworkApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp.Seeder;

public static class EntitySeeder
{
    public static void SeedUsers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User()
            {
                IdUser = 1,
                FirstName = "Stefan",
                LastName = "Kowalski",
                Username = "nick123",
                Password = "qwerty",
                Description = "",
            },
            new User()
            {
                IdUser = 2,
                FirstName = "Anna",
                LastName = "Nowak",
                Username = "anna456",
                Password = "asdfgh",
                Description = "",
            },
            new User()
            {
                IdUser = 3,
                FirstName = "John",
                LastName = "Smith",
                Username = "john789",
                Password = "zxcvbn",
                Description = "",
            },
            new User()
            {
                IdUser = 4,
                FirstName = "Maria",
                LastName = "Garcia",
                Username = "maria654",
                Password = "poiuyt",
                Description = "",
            },
            new User()
            {
                IdUser = 5,
                FirstName = "James",
                LastName = "Brown",
                Username = "james321",
                Password = "lkjhgf",
                Description = "",
            },
            new User()
            {
                IdUser = 6,
                FirstName = "Emily",
                LastName = "Davis",
                Username = "emily987",
                Password = "mnbvcx",
                Description = "",
            },
            new User()
            {
                IdUser = 7,
                FirstName = "Michael",
                LastName = "Taylor",
                Username = "mike741",
                Password = "trewq",
                Description = "",
            },
            new User()
            {
                IdUser = 8,
                FirstName = "Sophia",
                LastName = "Martinez",
                Username = "sophia852",
                Password = "gfdsa",
                Description = "",
            },
            new User()
            {
                IdUser = 9,
                FirstName = "David",
                LastName = "Wilson",
                Username = "david963",
                Password = "plokij",
                Description = "",
            },
            new User()
            {
                IdUser = 10,
                FirstName = "Olivia",
                LastName = "Thomas",
                Username = "olivia159",
                Password = "vfrtgb",
                Description = "",
            }
        );
    }

    public static void SeedUserDepartments(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDepartment>().HasData(
            new UserDepartment { UserId = 1, DepartmentId = 1 },
            new UserDepartment { UserId = 2, DepartmentId = 1 },
            new UserDepartment { UserId = 3, DepartmentId = 2 },
            new UserDepartment { UserId = 4, DepartmentId = 2 },
            new UserDepartment { UserId = 5, DepartmentId = 2 },
            new UserDepartment { UserId = 6, DepartmentId = 1 },
            new UserDepartment { UserId = 7, DepartmentId = 2 },
            new UserDepartment { UserId = 8, DepartmentId = 1 },
            new UserDepartment { UserId = 9, DepartmentId = 2 },
            new UserDepartment { UserId = 10, DepartmentId = 1 }
        );
    }

    public static void SeedDepartments(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData(
            new Department()
            {
                IdDepartment = 1,
                Address = "123 Main St, Cityville",
                DepartmentName = "HR",
                Description = "Handles human resources tasks",
                MainMail = "hr@company.com",
                MainPhone = "123-456-7890",
                MainWww = "www.hr.company.com"
            },
            new Department()
            {
                IdDepartment = 2,
                Address = "456 Elm St, Townsville",
                DepartmentName = "IT",
                Description = "Responsible for IT infrastructure",
                MainMail = "it@company.com",
                MainPhone = "987-654-3210",
                MainWww = "www.it.company.com"
            }
        );
    }

    public static void SeedPayments(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Payment>().HasData(
            new Payment()
            {
                IdPayment = 1,
                Bonus = 0,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2024, 1, 15), DateTimeKind.Utc),
                IdUser = 1,
                Pay = 3000
            },
            new Payment()
            {
                IdPayment = 2,
                Bonus = 0,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2024, 2, 15), DateTimeKind.Utc),
                IdUser = 2,
                Pay = 2500
            },
            new Payment()
            {
                IdPayment = 3,
                Bonus = 0,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2024, 3, 15), DateTimeKind.Utc),
                IdUser = 3,
                Pay = 2800
            },
            new Payment()
            {
                IdPayment = 4,
                Bonus = 300,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2020, 3, 15), DateTimeKind.Utc),
                IdUser = 4,
                Pay = 2800
            },
            new Payment()
            {
                IdPayment = 5,
                Bonus = 150,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2020, 4, 15), DateTimeKind.Utc),
                IdUser = 4,
                Pay = 2800
            },
            new Payment()
            {
                IdPayment = 6,
                Bonus = 250,
                DateOfPayment = DateTime.SpecifyKind(new DateTime(2020, 5, 15), DateTimeKind.Utc),
                IdUser = 4,
                Pay = 2800
            }
        );
    }
}
