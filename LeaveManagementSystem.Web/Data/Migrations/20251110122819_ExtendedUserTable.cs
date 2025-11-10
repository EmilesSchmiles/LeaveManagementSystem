using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2355436-8e9e-4938-9d32-8eef89e530da",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "604c40a7-439f-4cb7-ab51-e006b44c8657", new DateOnly(1990, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEEwJ2uXXTc0C2YbIUtG5/Yzh+6fRauWWmC2tN58cvncuhTwoaDKi8mYTtqbFUtmwjw==", "e7f4b589-cb2b-4a57-8449-69f691e1519c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2355436-8e9e-4938-9d32-8eef89e530da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e599671-0080-46ac-96d4-b81547cab4c8", "AQAAAAIAAYagAAAAEBFKeMgTZOjbVU3Qw3hDEn+jaIB+ju3NysjN04OIVlH4loL4QPDi6PN/2cSVdh6iGA==", "6a49ae51-8d6a-4d28-8afa-76e79a31038a" });
        }
    }
}
