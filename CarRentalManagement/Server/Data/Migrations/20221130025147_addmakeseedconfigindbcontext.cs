using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class addmakeseedconfigindbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 30, 10, 51, 47, 278, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 11, 30, 10, 51, 47, 279, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 30, 10, 51, 47, 280, DateTimeKind.Local).AddTicks(1460), new DateTime(2022, 11, 30, 10, 51, 47, 280, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 30, 10, 51, 47, 281, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 11, 30, 10, 51, 47, 281, DateTimeKind.Local).AddTicks(6543), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 30, 10, 51, 47, 281, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 11, 30, 10, 51, 47, 281, DateTimeKind.Local).AddTicks(6548), "Toyota", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 30, 10, 49, 39, 527, DateTimeKind.Local).AddTicks(1884), new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(6864), new DateTime(2022, 11, 30, 10, 49, 39, 529, DateTimeKind.Local).AddTicks(6872) });
        }
    }
}
