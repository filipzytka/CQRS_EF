using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkApp.Migrations
{
    /// <inheritdoc />
    public partial class NewSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "IdDepartment", "Address", "DepartmentName", "Description", "MainMail", "MainPhone", "MainWww" },
                values: new object[,]
                {
                    { 1, "123 Main St, Cityville", "HR", "Handles human resources tasks", "hr@company.com", "123-456-7890", "www.hr.company.com" },
                    { 2, "456 Elm St, Townsville", "IT", "Responsible for IT infrastructure", "it@company.com", "987-654-3210", "www.it.company.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Description", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "", "Stefan", "Kowalski", "qwerty", "nick123" },
                    { 2, "", "Anna", "Nowak", "asdfgh", "anna456" },
                    { 3, "", "John", "Smith", "zxcvbn", "john789" },
                    { 4, "", "Maria", "Garcia", "poiuyt", "maria654" },
                    { 5, "", "James", "Brown", "lkjhgf", "james321" },
                    { 6, "", "Emily", "Davis", "mnbvcx", "emily987" },
                    { 7, "", "Michael", "Taylor", "trewq", "mike741" },
                    { 8, "", "Sophia", "Martinez", "gfdsa", "sophia852" },
                    { 9, "", "David", "Wilson", "plokij", "david963" },
                    { 10, "", "Olivia", "Thomas", "vfrtgb", "olivia159" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "IdPayment", "Bonus", "DateOfPayment", "IdUser", "Pay" },
                values: new object[,]
                {
                    { 1, 0f, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 1, 3000f },
                    { 2, 0f, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2, 2500f },
                    { 3, 0f, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3, 2800f },
                    { 4, 300f, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4, 2800f },
                    { 5, 150f, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4, 2800f },
                    { 6, 250f, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4, 2800f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "IdDepartment",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "IdDepartment",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "IdPayment",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 4);
        }
    }
}
