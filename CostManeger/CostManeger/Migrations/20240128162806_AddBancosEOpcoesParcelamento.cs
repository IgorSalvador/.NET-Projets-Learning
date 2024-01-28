using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostManeger.Migrations
{
    public partial class AddBancosEOpcoesParcelamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcelamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelamento", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Parcelamento",
                columns: new[] { "Id", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "1x - Preço à vista.", true },
                    { 2, "2x - ", true },
                    { 3, "3x - ", true },
                    { 4, "4x - ", true },
                    { 5, "5x - ", true },
                    { 6, "6x - ", true },
                    { 7, "7x - ", true },
                    { 8, "8x - ", true },
                    { 9, "9x - ", true },
                    { 10, "10x - ", true },
                    { 11, "11x - ", true },
                    { 12, "12x - ", true }
                });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 13, 28, 6, 677, DateTimeKind.Unspecified).AddTicks(3035), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 13, 28, 6, 677, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 13, 28, 6, 677, DateTimeKind.Unspecified).AddTicks(3040), new TimeSpan(0, -3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bancos");

            migrationBuilder.DropTable(
                name: "Parcelamento");

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
    }
}
