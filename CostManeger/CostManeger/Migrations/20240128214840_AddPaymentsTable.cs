using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostManeger.Migrations
{
    public partial class AddPaymentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InstallmentId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Bancos_BankId",
                        column: x => x.BankId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Parcelamento_InstallmentId",
                        column: x => x.InstallmentId,
                        principalTable: "Parcelamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8183), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_BankId",
                table: "Pagamentos",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_InstallmentId",
                table: "Pagamentos",
                column: "InstallmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_UserId",
                table: "Pagamentos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamentos");

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
    }
}
