using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostManeger.Migrations
{
    public partial class AddBooleanReferenceForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 20, 18, 53, 54, DateTimeKind.Unspecified).AddTicks(705), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 20, 18, 53, 54, DateTimeKind.Unspecified).AddTicks(707), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 20, 18, 53, 54, DateTimeKind.Unspecified).AddTicks(710), new TimeSpan(0, -3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1732), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
