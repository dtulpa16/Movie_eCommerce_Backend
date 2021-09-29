using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class _SeedRolescs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34063a13-4613-4447-827a-c583337e1788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0c27b1c-16de-45bb-bbd1-d35b825de6d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b017da4-8d6c-4b1f-8a04-208c83b0b715", "7b6413f8-62f8-4abe-8b3a-93bd6aa8c43f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffe3495d-ca1d-46a0-a6ea-24991f1a4aac", "48b6f161-e6f7-4bf9-8961-3c2e4c03a809", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b017da4-8d6c-4b1f-8a04-208c83b0b715");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffe3495d-ca1d-46a0-a6ea-24991f1a4aac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34063a13-4613-4447-827a-c583337e1788", "94f46798-3b74-4ac3-b8ab-7e16f6e08a6b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0c27b1c-16de-45bb-bbd1-d35b825de6d3", "f0fee98e-d067-4043-a4bf-3c5203bd90cc", "Admin", "ADMIN" });
        }
    }
}
