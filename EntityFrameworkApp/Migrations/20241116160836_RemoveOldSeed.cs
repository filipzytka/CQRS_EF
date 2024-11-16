using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOldSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
