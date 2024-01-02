using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostManeger.Migrations
{
    public partial class AddBooleanReferenceToProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Perfis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1728), new TimeSpan(0, -3, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1730), new TimeSpan(0, -3, 0, 0, 0)), true });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "IsActive" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 1, 1, 18, 16, 39, 654, DateTimeKind.Unspecified).AddTicks(1732), new TimeSpan(0, -3, 0, 0, 0)), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Perfis");

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
