using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkApp.Migrations
{
    /// <inheritdoc />
    public partial class UserDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentUser");

            migrationBuilder.CreateTable(
                name: "UserDepartments",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDepartments", x => new { x.DepartmentId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDepartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDepartments_UserId",
                table: "UserDepartments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDepartments");

            migrationBuilder.CreateTable(
                name: "DepartmentUser",
                columns: table => new
                {
                    DepartmentsIdDepartment = table.Column<int>(type: "integer", nullable: false),
                    UsersIdUser = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentUser", x => new { x.DepartmentsIdDepartment, x.UsersIdUser });
                    table.ForeignKey(
                        name: "FK_DepartmentUser_Departments_DepartmentsIdDepartment",
                        column: x => x.DepartmentsIdDepartment,
                        principalTable: "Departments",
                        principalColumn: "IdDepartment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentUser_Users_UsersIdUser",
                        column: x => x.UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentUser_UsersIdUser",
                table: "DepartmentUser",
                column: "UsersIdUser");
        }
    }
}
