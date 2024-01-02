using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostManeger.Migrations
{
    public partial class CreateProfileTableAndDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Perfis",
                columns: new[] { "Id", "CreatedOn", "Description" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8713), new TimeSpan(0, -3, 0, 0, 0)), "General" });

            migrationBuilder.InsertData(
                table: "Perfis",
                columns: new[] { "Id", "CreatedOn", "Description" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, -3, 0, 0, 0)), "Viewer" });

            migrationBuilder.InsertData(
                table: "Perfis",
                columns: new[] { "Id", "CreatedOn", "Description" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2024, 1, 1, 18, 14, 8, 755, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, -3, 0, 0, 0)), "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perfis");
        }
    }
}
