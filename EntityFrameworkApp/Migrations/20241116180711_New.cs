using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkApp.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserDepartments",
                columns: new[] { "DepartmentId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 1, 8 },
                    { 2, 9 },
                    { 1, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "UserDepartments",
                keyColumns: new[] { "DepartmentId", "UserId" },
                keyValues: new object[] { 1, 10 });
        }
    }
}
