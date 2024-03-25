using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Uygulama.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sanatcis",
                columns: new[] { "Id", "Adi", "CreatedDate", "DeletedDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Barış Manço", new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5658), null, 0, null },
                    { 2, "Barış Akarsu", new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5674), null, 0, null },
                    { 3, "Sıla", new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5675), null, 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
