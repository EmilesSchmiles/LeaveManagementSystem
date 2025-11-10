using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02f999fc-fda1-4f6d-b829-cd24365ba5d3", null, "Employee", "EMPLOYEE" },
                    { "c5720a69-716d-4f65-8b96-461ad5d454f1", null, "Administrator", "ADMINISTRATOR" },
                    { "ff18ba14-11e7-4e50-8791-c3f17850b977", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2355436-8e9e-4938-9d32-8eef89e530da", 0, "0e599671-0080-46ac-96d4-b81547cab4c8", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEBFKeMgTZOjbVU3Qw3hDEn+jaIB+ju3NysjN04OIVlH4loL4QPDi6PN/2cSVdh6iGA==", null, false, "6a49ae51-8d6a-4d28-8afa-76e79a31038a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c5720a69-716d-4f65-8b96-461ad5d454f1", "c2355436-8e9e-4938-9d32-8eef89e530da" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f999fc-fda1-4f6d-b829-cd24365ba5d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff18ba14-11e7-4e50-8791-c3f17850b977");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c5720a69-716d-4f65-8b96-461ad5d454f1", "c2355436-8e9e-4938-9d32-8eef89e530da" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5720a69-716d-4f65-8b96-461ad5d454f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2355436-8e9e-4938-9d32-8eef89e530da");
        }
    }
}
