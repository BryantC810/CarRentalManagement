using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class fixedseedfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 11, 30, 10, 49, 39, 527, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(5673), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(6864), new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(6872), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
