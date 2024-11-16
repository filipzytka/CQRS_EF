using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkApp.Migrations
{
    /// <inheritdoc />
    public partial class JoinEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments",
                columns: new[] { "UserId", "DepartmentId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments");

            migrationBuilder.DropIndex(
                name: "IX_UserDepartments_DepartmentId",
                table: "UserDepartments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDepartments",
                table: "UserDepartments",
                columns: new[] { "DepartmentId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments",
                column: "UserId");
        }
    }
}
